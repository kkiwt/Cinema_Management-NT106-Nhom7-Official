using System;
using System.Threading.Tasks;
using Supabase;

namespace ServerAndService
{
    internal class Service
    {
        private static Client _client;
        private static bool _initialized = false;

        public Service()
        {
            if (!_initialized)
            {
                InitializeSupabase().Wait();
                _initialized = true;
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

            _client = new Supabase.Client(url, key, options); // ⚠️ Gán cho _client
            await _client.InitializeAsync();

            Console.WriteLine("Supabase connected successfully!");
        }


        // 🟢 Đăng ký tài khoản
        public async Task<string> RegisterUser(
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
                var result = await _client.Rpc("register_user", new
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
                var result = await _client.Rpc("login_user", new
                {
                    _username = username,
                    _password = passwordHash
                });

                return result.Content.Trim(); // LOGIN_SUCCESS hoặc ERROR_LOGIN
            }
            catch (Exception ex)
            {
                return $"ERROR_LOGIN: {ex.Message}";
            }
        }

 
    }
}
