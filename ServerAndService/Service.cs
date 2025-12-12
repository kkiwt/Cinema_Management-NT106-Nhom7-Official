using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Text.Json; 
using System.Threading.Tasks;
using System.Xml.Schema;

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
        public async Task<string> RequestPasswordReset(string email)
        {
            var result = await client.Rpc("request_password_reset", new { _email = email });

            return result.Content; // Trả về OTP hoặc EMAIL_NOT_FOUND
        }



        public async Task<string> GetCinemaStats() // Cai ham can gui
        {
            try
            {
                var result = await client.Rpc("get_cinema_stats", new { });
                return result.Content?.Trim();
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_STATS: {ex.Message}";
            }
        }






        public async Task<string> UploadPosterBase64Async(string base64String)
        {
            try
            {
                var bucketName = "Anh";
                string fileName = "poster_" + Guid.NewGuid() + ".jpg";
                byte[] bytes = Convert.FromBase64String(base64String);

                var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF5aGFtcmFubGptZnNyeGZ4ZmxzIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc2MTQ2ODMzNCwiZXhwIjoyMDc3MDQ0MzM0fQ.DaDBscqR8J0NrCnOMZZHOfq9LyKqtbM6odoyFIZxAFs";

                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + key);
                httpClient.DefaultRequestHeaders.Add("apikey", key);

                var content = new ByteArrayContent(bytes);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                var url = $"https://qyhamranljmfsrxfxfls.supabase.co/storage/v1/object/{bucketName}/{fileName}";
                var response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return $"https://qyhamranljmfsrxfxfls.supabase.co/storage/v1/object/public/{bucketName}/{fileName}";
                }
                else
                {
                    string errorDetail = await response.Content.ReadAsStringAsync();
                    return $"ERROR_UPLOAD: {response.StatusCode} - {errorDetail}";
                }
            }
            catch (Exception ex)
            {
                return $"ERROR_UPLOAD: {ex.Message}";
            }
        }








        public async Task<string> AddPhimRPC(
            string idPhim, string tenPhim, string theLoai, string doTuoi,
            int thoiLuong, string moTa, string urlTrailer, string posterPhim,
            string daoDien, string dienVien, string ngonNgu, string quocGia,
            DateTime tuNgay, DateTime denNgay)
        {
            var result = await client.Rpc("add_phim", new
            {
                p_idphim = idPhim,
                p_tenphim = tenPhim,
                p_theloai = theLoai,
                p_dotuoi = doTuoi,
                p_thoiluong = thoiLuong,
                p_mota = moTa,
                p_urltrailer = urlTrailer,
                p_posterphim = posterPhim,
                p_daodien = daoDien,
                p_dienvien = dienVien,
                p_ngonngu = ngonNgu, // thêm
                p_quocgia = quocGia,
                p_tungay = tuNgay.ToString("yyyy-MM-dd"),
                p_denngay = denNgay.ToString("yyyy-MM-dd")
            });
            return result.Content.Trim('"');
        }








        // Service.cs — THÊM HÀM RPC tạo lịch cố định
        public async Task<string> CreateLichCoDinhForPhim(string idPhim)
        {

            var result = await client.Rpc("tao_lich_codinh_roundrobin_10phong",
                                          new { p_idphim = idPhim });
            return result.Content?.Trim('\"');

        }

        // Service.cs — SỬA CHỮA AddPhimFullFlow: KHÔNG CẦN danhSachGio/phongChieu nữa
        public async Task<string> AddPhimFullFlow(
            string tenPhim, string theLoai, string doTuoi, int thoiLuong, string moTa,
            string urlTrailer, string posterBase64, string daoDien, string dienVien,
            string ngonNgu, string quocGia, DateTime tuNgay, DateTime denNgay
        )
        {
            try
            {
                // 1) Upload poster
                string posterUrl = await UploadPosterBase64Async(posterBase64);
                if (posterUrl.StartsWith("ERROR")) return posterUrl;

                // 2) Lấy IdPhim mới
                string idPhim = await GetNextIdPhimAsync();

                // 3) Gọi RPC add_phim
                string insertResult = await AddPhimRPC(
                    idPhim, tenPhim, theLoai, doTuoi, thoiLuong, moTa,
                    urlTrailer, posterUrl, daoDien, dienVien, ngonNgu, quocGia,
                    tuNgay, denNgay
                );
                if (!insertResult.Contains("SUCCESS"))
                    return insertResult;

                // 4) Sinh lịch cố định cho phim (10 phòng riêng, round-robin khung giờ)
                string lichResult = await CreateLichCoDinhForPhim(idPhim);
                if (string.IsNullOrWhiteSpace(lichResult) || lichResult.StartsWith("ERROR"))
                    return $"ERROR_CREATE_SCHEDULE: {lichResult ?? "NULL"}";

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return $"ERROR: {ex.Message}";
            }
        }


        public async Task<string> GetNextIdPhimAsync()
        {
            var result = await client.Rpc("get_next_idphim", new { });
            return result.Content.Trim('"');
        }
        // Service.cs

        public async Task<string> GetLichSuVeAllRPC() // Cai nay moi them
        {
            try
            {
                var result = await client.Rpc("get_lichsu_all", new { });
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_SERVICE_GET_HISTORY_ALL: {ex.Message}";
            }
        }

        public async Task<string> GetMoviesListRPC(int limitCount = 100) // Cai nay moi them
        {
            try
            {
                var result = await client.Rpc("get_movies_list", new
                {
                    limit_count = limitCount
                });

                var json = result.Content?.Trim();
                // Phòng trường hợp Supabase trả null/rỗng
                if (string.IsNullOrWhiteSpace(json) || json == "null")
                    return "[]";

                return json; // JSON array: [{IdPhim, TenPhim, ChieuTu, DenNgay}, ...]
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_MOVIES_LIST: {ex.Message}";
            }
        }


        public async Task<string> XoaPhimRPC(string idPhim) // cai moi them
        {
            try
            {
                var result = await client.Rpc("xoa_phim", new { p_idphim = idPhim });
                // Vì hàm trả về VOID, Supabase trả về chuỗi rỗng hoặc null
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return $"ERROR_XOA_PHIM: {ex.Message}";
            }
        }


        public async Task<string> GetCinemaStats2() // Cai ham can gui // cai so 2 la cai chinh thuc
        {
            try
            {
                var result = await client.Rpc("get_cinema_stats", new { });
                return result.Content?.Trim();
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_STATS: {ex.Message}";
            }
        }










        public async Task<string> GetAvailableSlotsRPC(string phongId, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var result = await client.Rpc("getavailableslots", new
                {
                    p_phong_id = phongId,
                    p_tu_ngay = tuNgay.ToString("yyyy-MM-dd"),
                    p_den_ngay = denNgay.ToString("yyyy-MM-dd")
                });

                return result.Content.Trim('"'); // Ví dụ: "G1,G2,G3" hoặc "EMPTY"
            }
            catch (Exception ex)
            {
                return $"ERROR: {ex.Message}";
            }
        }







        public async Task<string> ConfirmPasswordReset(string email, string otp, string newPass)
        {
            var result = await client.Rpc("confirm_password_reset", new
            {
                _email = email,
                _otp = otp,
                _newpassword = newPass
            });

            return result.Content.Trim('"'); // RESET_SUCCESS hoặc OTP_INVALID
        }

        public async Task<string> AddGiamGiaRPC(string id, DateTime tuNgay, DateTime denNgay, decimal tiLe) // Cai Nay them o file Service.cs
        {
            try
            {
                var result = await client.Rpc("add_giamgia", new
                {
                    p_id = id,
                    p_tungay = tuNgay.ToString("yyyy-MM-dd"),
                    p_denngay = denNgay.ToString("yyyy-MM-dd"),
                    p_tile = tiLe
                });

                return result.Content.Trim('"'); // Trả về SUCCESS hoặc FAILED
            }
            catch (Exception ex)
            {
                return $"ERROR_ADD_GIAMGIA: {ex.Message}";
            }
        }
        public async Task<string> CheckOtp(string email, string otp)
        {
            var result = await client.Rpc("check_otp", new { _email = email, _otp = otp });
            return result.Content.Trim('"'); // Trả về OTP_VALID hoặc OTP_INVALID
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
                    bool laNhanVien = firstRow.GetProperty("lanhanvien").GetBoolean();

                    return $"[LOGIN_SUCCESS]|{id}|{hoTen}|{userName}|{email}|{sdt}|{gioiTinh}|{ngaySinh:yyyy-MM-dd}|{laNhanVien}";

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


        public async Task<string> GetLatestMoviesRPC(int limitCount) // toi da 100 phim
        {
            try
            {
                // Gọi RPC
                var result = await client.Rpc("get_latest_movies2", new
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

        public async Task<string> DeleteReview(string idReview)
        {
            try
            {
                var result = await client.Rpc("delete_review", new
                {
                    p_idreview = idReview
                });

                return result.Content.Trim('"'); // SUCCESS hoặc FAILED
            }
            catch (Exception ex)
            {
                return $"ERROR_DELETE_REVIEW: {ex.Message}";
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
        public async Task<string> GetGiamGiaRPC()
        {
            try
            {
                var result = await client.Rpc("get_giamgia", new { });
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null")
                    return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_SERVICE_GET_GIAMGIA: {ex.Message}";
            }
        }
        public async Task<string> GetVeDaDatRPC(string idTaiKhoan)
        {
            try
            {
                var result = await client.Rpc("get_ve_dadat", new { _idtaikhoan = idTaiKhoan });
                var json = result.Content?.Trim();

                if (string.IsNullOrWhiteSpace(json) || json == "null")
                    return "[]";

                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_SERVICE_GET_VE_DADAT: {ex.Message}";
            }
        }
        // Lấy thông tin phim theo Id
        public async Task<string> GetPhimById(string idPhim)
        {
            try
            {
                var result = await client.Rpc("get_phim_by_id", new { p_idphim = idPhim });
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_PHIM: {ex.Message}";
            }
        }

        // Lấy danh sách khung giờ cố định của phim
        public async Task<string> GetLichChieuCoDinh(string idPhim)
        {
            try
            {
                var result = await client.Rpc("get_lichchieucodinh_by_phim", new { p_idphim = idPhim });
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_LICHCHIEU_CODINH: {ex.Message}";
            }
        }

        // Lấy toàn bộ khung giờ
        public async Task<string> GetKhungGio()
        {
            try
            {
                var result = await client.Rpc("get_khunggio", new { });
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_KHUNG_GIO: {ex.Message}";
            }
        }

        // Lấy danh sách phòng chiếu
        public async Task<string> GetPhongChieu()
        {
            try
            {
                var result = await client.Rpc("get_phongchieu", new { });
                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_PHONG_CHIEU: {ex.Message}";
            }
        }
        public async Task<string> HoldSeatAsync(string idPhim, string idKhungGio, string idPhongChieu, DateTime ngayDat, string idGhe, string idTaiKhoan)
        {
            try
            {
                var result = await client.Rpc("hold_seat", new
                {
                    p_idphim = idPhim,
                    p_idkhunggio = idKhungGio,
                    p_idphongchieu = idPhongChieu,
                    p_ngaydat = ngayDat.Date,
                    p_idghe = idGhe,
                    p_idtaikhoan = idTaiKhoan
                });

                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "{}";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_HOLD_SEAT: {ex.Message}";
            }
        }
        public async Task<string> SetVeAsync(
    string idPhim, string idKhungGio, string idPhongChieu,
    DateTime ngayDat, string idGhe, string idTaiKhoan,
    decimal giaVe, string idThanhToan)
        {
            try
            {
                var result = await client.Rpc("set_ve", new
                {
                    p_idphim = idPhim,
                    p_idkhunggio = idKhungGio,
                    p_idphongchieu = idPhongChieu,
                    p_ngaydat = ngayDat.Date,
                    p_idghe = idGhe,
                    p_idtaikhoan = idTaiKhoan,
                    p_giave = giaVe,
                    p_idthanhtoan = idThanhToan,
                });

                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "{}";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_SET_VE: {ex.Message}";
            }
        }

        public async Task<string> GetSeatStatusAsync(string idPhim, string idKhungGio, string idPhongChieu, DateTime ngayDat)
        {
            try
            {
                var result = await client.Rpc("get_seatstatus", new
                {
                    p_idphim = idPhim,
                    p_idkhunggio = idKhungGio,
                    p_idphongchieu = idPhongChieu,
                    p_ngaydat = ngayDat.Date
                });

                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "[]";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_GET_SEATSTATUS: {ex.Message}";
            }
        }
        public async Task<string> RemoveHoldSeatAsync(
            string idPhim, string idKhungGio, string idPhongChieu,
            DateTime ngayDat, string idGhe, string idTaiKhoan)
        {
            var result = await client.Rpc("remove_holdseat", new Dictionary<string, object>
            {
            { "p_idphim", idPhim },
            { "p_idkhunggio", idKhungGio },
            { "p_idphongchieu", idPhongChieu },
            { "p_ngaydat", ngayDat },
            { "p_idghe", idGhe },
            { "p_idtaikhoan", idTaiKhoan }
            });

            return result?.ToString() ?? "ERROR: remove_holdseat failed";
        }

        public async Task<string> CheckPaymentAsync(string idThanhToan)
        {
            var response = await client.Rpc("check_payment", new Dictionary<string, object>
            {
                { "p_idthanhtoan", idThanhToan }
            });

            var json = response.Content;
            if (string.IsNullOrEmpty(json))
                return "{\"error\":\"check_payment failed\"}";

            return json;
        }

        public async Task<string> DeleteTicketAsync(string idPhim, string idKhungGio, string idPhongChieu, DateTime ngayDat, string idGhe, string idTaiKhoan)
        {
            try
            {
                var result = await client.Rpc("delete_ticket", new
                {
                    p_idphim = idPhim,
                    p_idkhunggio = idKhungGio,
                    p_idphongchieu = idPhongChieu,
                    p_ngaydat = ngayDat.Date,
                    p_idghe = idGhe,
                    p_idtaikhoan = idTaiKhoan
                });

                var json = result.Content?.Trim();
                if (string.IsNullOrWhiteSpace(json) || json == "null") return "{\"success\":false,\"message\":\"Lỗi xóa vé\"}";
                return json;
            }
            catch (Exception ex)
            {
                return $"ERROR_DELETE_TICKET: {ex.Message}";
            }
        }
        public async Task<string> GetGiamGiaAsync(string idGiamGia)
        {
            var response = await client.Rpc("get_giamgia", new Dictionary<string, object>
    {
        { "p_idgiamgia", idGiamGia }
    });

            var json = response.Content;

            if (string.IsNullOrEmpty(json))
                return "{\"error\":\"get_giamgia failed\"}";

            return json;
        }
        public async Task<string> SetGiamGiaTaiKhoanAsync(string idGiamGia, string idTaiKhoan)
        {
            var response = await client.Rpc("setgiamgiataikhoan", new Dictionary<string, object>
    {
        { "p_idgiamgia", idGiamGia },
        { "p_idtaikhoan", idTaiKhoan }
    });

            var json = response.Content;

            if (string.IsNullOrEmpty(json))
                return "{\"error\":\"set_giamgia_taikhoan failed\"}";

            return json;
        }
        public async Task<string> UnsetGiamGiaTaiKhoanAsync(string idGiamGia, string idTaiKhoan)
        {
            var response = await client.Rpc("unsetgiamgiataikhoan", new Dictionary<string, object>
    {
        { "p_idgiamgia", idGiamGia },
        { "p_idtaikhoan", idTaiKhoan }
    });

            var json = response.Content;

            if (string.IsNullOrEmpty(json))
                return "{\"error\":\"unset_giamgia_taikhoan failed\"}";

            return json;
        }
        public async Task<string> RemoveThanhToanBapNuocAsync(string idThanhToan)
        {
            var response = await client.Rpc("rm_thanhtoan_bapnuoc", new Dictionary<string, object>
    {
        { "p_idthanhtoan", idThanhToan }
    });
            var json = response.Content;
            if (string.IsNullOrEmpty(json))
                return "NO_RESPONSE";
            else if (json.Contains("NOT_FOUND"))
                return "NOT_FOUND";
            return json;
        }
        public async Task<string> AddThanhToanBapNuocAsync(string idThanhToan, string idTaiKhoan, string idBapNuoc, decimal tongtien, string trangthai, DateTime ngaydat)
        {
            var response = await client.Rpc("add_thanhtoan_bapnuoc", new Dictionary<string, object>
            {
                { "p_idthanhtoan", idThanhToan },
                { "p_idtaikhoan", idTaiKhoan },
                { "p_idbapnuoc", idBapNuoc },
                { "p_tongtien", tongtien },
                { "p_trangthai", trangthai },
                { "p_ngaydat", ngaydat }
            });
            var json = response.Content;
            if (json.Contains("FAILED") || string.IsNullOrEmpty(json))
                return "FAILED";
            return json;
        }
        public async Task<string> SetGiamGiaAsync(string idGiamGia)
        {
            try
            {
                var result = await client.Rpc("setgiamgia", new
                {
                    p_idgiamgia = idGiamGia
                });
                return "OK";
            }
            catch (Exception ex)
            {
                return $"ERROR_SET_GIAMGIA: {ex.Message}";
            }
        }
        public async Task<string> UnsetGiamGiaAsync(string idGiamGia)
        {
            try
            {
                var result = await client.Rpc("unsetgiamgia", new
                {
                    p_idgiamgia = idGiamGia
                });
                return "OK";
            }
            catch (Exception ex)
            {
                return $"ERROR_UNSET_GIAMGIA: {ex.Message}";
            }
        }
    }

}