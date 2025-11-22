using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Text.Json; 
using System.Threading.Tasks;

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

            client = new Supabase.Client(url, key, options);
            await client.InitializeAsync();

            Console.WriteLine("Supabase connected successfully!");
        }


        // Đăng ký tài khoản
        public async Task<string> RegisterUser
            (
                   string hoTen,
                   string username,
                   string passwordHash,  // Đã băm SHA256 ở client
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

        // Đăng nhập user (ví dụ)
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

        
        public async Task<string> GetMovies()
        {
            try
            {
                // Sử dụng client đã được khởi tạo tĩnh
                var Response = await client.From<Movie>().Get();

                // Serialize danh sách Models thành JSON string
                string json = JsonSerializer.Serialize(Response.Models);

                // Trả về JSON string của danh sách phim
                return json;
            }
            catch (Exception ex)
            {
                // Trả về chuỗi lỗi nếu có vấn đề
                return $"ERROR_GET_MOVIES: {ex.Message}";
            }
        }
        
        public async Task<string> GetLatestMoviesRPC(int limitCount)
        {
            try
            {
                // Gọi RPC
                var result = await client.Rpc("get_latest_movies", new
                {
                    limit_count = limitCount
                });

                var json = result.Content?.Trim();

                // Xử lý phản hồi rỗng hoặc không hợp lệ (nếu Supabase trả về null/rỗng)
                if (string.IsNullOrWhiteSpace(json) || json == "null" || json == "[]")
                {
                    return "[]"; // Trả về JSON Array rỗng hợp lệ
                }
                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calling get_latest_movies: {ex.Message}");
                return $"ERROR_GET_LATEST_MOVIES: {ex.Message}";
            }
        }


        // File Service.cs (Phiên bản đơn giản hóa, giả định hàm SQL đã trả về đủ)
        public async Task<string> GetReviewSummary(string idPhim)
        {
            try
            {
                // Chỉ gọi một hàm RPC duy nhất
                var result = await client.Rpc("get_review_summary", new
                {
                    p_idphim = idPhim
                });

                string json = result.Content?.Trim();

                // Xử lý phản hồi rỗng hoặc không hợp lệ (nếu Supabase trả về null/rỗng)
                if (string.IsNullOrWhiteSpace(json) || json == "null" || json == "[]")
                {
                    // Trả về JSON hợp lệ với giá trị mặc định nếu không tìm thấy
                    return "{\"avg_rating\": 0, \"total_reviews\": 0, \"latest_reviews\": []}";
                }

                // Supabase trả về mảng JSON, ta chỉ cần phần tử đầu tiên
                if (json.StartsWith("[")) json = json.Trim(['[', ']']);

                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calling get_review_summary: {ex.Message}");
                return $"ERROR_GET_REVIEW_SUMMARY: {ex.Message}";
            }
        }

        public async Task<string> PostReview(string idTaiKhoan, string idPhim, string noiDung, int soSao)
        {
            try
            {
                var result = await client.Rpc("insert_review", new
                {
                    _idtaikhoan = idTaiKhoan,
                    _idphim = idPhim,
                    _noidung = noiDung,
                    _sosao = soSao
                });
                var responseText = result.Content?.Trim();

                if (string.IsNullOrWhiteSpace(responseText) || responseText.Contains("SUCCESS"))
                {
                    return "SUCCESS";
                }

                return responseText;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calling insert_review: {ex.Message}");
                return $"ERROR_POST_REVIEW_SERVICE: {ex.Message}";
            }
        }
    }
}
