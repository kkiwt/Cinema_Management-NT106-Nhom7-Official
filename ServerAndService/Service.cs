using System;
using System.Threading.Tasks;
using Supabase;

namespace ServerAndService
{
    internal class Service
    {
        private static Client client;
        private static bool initialized = false;

        public Service()
        {
            if (!initialized)
            {
                InitializeSupabase().Wait();
                initialized = true;
            }
        }

        private async Task InitializeSupabase()
        {
            var url = "https://qyhamranljmfsrxfxfls.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF5aGFtcmFubGptZnNyeGZ4ZmxzIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc2MTQ2ODMzNCwiZXhwIjoyMDc3MDQ0MzM0fQ.DaDBscqR8J0NrCnOMZZHOfq9LyKqtbM6odoyFIZxAFs";

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = false,
                AutoRefreshToken = true
            };

            client = new Supabase.Client(url, key, options); // ⚠️ Gán cho _client
            await client.InitializeAsync();

            Console.WriteLine("Supabase connected successfully!");
        }


        // 🟢 Đăng ký tài khoản
        public async Task<string> RegisterUser
            (
                   string hoTen,
                   string username,
                   string passwordHash,  // Băm SHA256 ở client trước
                   string email,
                   string gioiTinh,
                   DateTime ngaySinh,
                   string soDienThoai
               )
        {
            try
            {
                var result = await client.Rpc("register_user", new
                {
                    _hoten = hoTen,
                    _username = username,
                    _password = passwordHash,
                    _email = email,
                    _gioitinh = gioiTinh,
                    _ngaysinh = ngaySinh.ToString("yyyy-MM-dd"),
                    _sodienthoai = soDienThoai
                });

                return result.Content.Trim(); // Ví dụ: REGISTER_SUCCESS, USERNAME_EXISTS, EMAIL_EXISTS
            }
            catch (Exception ex)
            {
                return $"ERROR_REGISTER: {ex.Message}";
            }
        }

        // 🔹 Đăng nhập user (ví dụ)
        public async Task<string> LoginUser(string username, string passwordHash)
        {
            try
            {
                var result = await client.Rpc("login_user", new
                {
                    _username = username,
                    _password = passwordHash

                });
                Console.WriteLine("🔹 Raw JSON from Supabase:");
                Console.WriteLine(result.Content);
                if (string.IsNullOrWhiteSpace(result.Content))
                    return "LOGIN_FAILED";

                // Supabase trả JSON, ví dụ:
                // [{"result":"LOGIN_SUCCESS","hoten":"Nguyen Van A","username":"admin",...}]
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "[]" || json == "{}")
                    return "LOGIN_FAILED";

                using var data = System.Text.Json.JsonDocument.Parse(json);
                if (data.RootElement.ValueKind != System.Text.Json.JsonValueKind.Array || data.RootElement.GetArrayLength() == 0)
                    return "LOGIN_FAILED";

                var firstRow = data.RootElement[0];


                string status = firstRow.GetProperty("result").GetString();

                if (status == "LOGIN_SUCCESS")
                {
                    string id = firstRow.GetProperty("idtaikhoan").GetString();
                    string hoTen = firstRow.GetProperty("hoten").GetString();
                    string userName = firstRow.GetProperty("username").GetString();
                    string email = firstRow.GetProperty("email").GetString();
                    string sdt = firstRow.GetProperty("sodienthoai").GetString();
                    string gioiTinh = firstRow.GetProperty("gioitinh").GetString();
                    DateTime ngaySinh = DateTime.TryParse(firstRow.GetProperty("ngaysinh").ToString(), out var ns)
                        ? ns : DateTime.MinValue;

                    return $"[LOGIN_SUCCESS]|{id}|{hoTen}|{userName}|{email}|{sdt}|{gioiTinh}|{ngaySinh:yyyy-MM-dd}";
                }


                return "LOGIN_FAILED";
            }
            catch (Exception ex)
            {
                return $"ERROR_LOGIN: {ex.Message}";
            }


        }



    }
}
