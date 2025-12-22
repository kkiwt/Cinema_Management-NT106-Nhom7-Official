using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerAndService
{
    internal class ServerTCP
    {
        private TcpListener listener;
        private Service service;

        public ServerTCP()
        {
            service = new Service();
        }

        public async Task StartAsync(int port = 7000)
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Console.WriteLine($"Server dang chay tai cong {port}...");

            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();
                _ = HandleClientAsync(client);
            }
        }



        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                Console.WriteLine("Client moi ket noi.");
                var stream = client.GetStream();

                var buffer = new byte[1048576]; // 1 Megabyte

                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                Console.WriteLine($"Nhan: {message}");

                //Check Data Rong
                if (string.IsNullOrWhiteSpace(message))
                {
                    await SendResponseAsync(stream, "ERROR: EMPTY_MESSAGE");
                    return;
                }

                string response;
                var parts = message.Split('|');
                var command = parts[0].ToUpper();

                switch (command)
                {
                    case "REGISTER":
                        if (parts.Length < 8)
                        {
                            response = "ERROR: REGISTER requires 7 parameters";
                        }
                        else
                        {
                            string hoTen = parts[1];
                            string username = parts[2];
                            string password = parts[3];
                            string email = parts[4];
                            string gioiTinh = parts[5];
                            string ngaySinhStr = parts[6];
                            string soDienThoai = parts[7];

                            if (!DateTime.TryParse(ngaySinhStr, out DateTime ngaySinh))
                            {
                                response = "ERROR: Invalid date format";
                                break;
                            }

                            response = await service.RegisterUser(
                                hoTen, username, password, email, gioiTinh, ngaySinh, soDienThoai);
                        }
                        break;

                    case "LOGIN":
                        if (parts.Length < 3)
                        {
                            response = "ERROR: LOGIN requires 2 parameters";
                        }
                        else
                        {
                            string username = parts[1];
                            string password = parts[2];
                            response = await service.LoginUser(username, password);
                        }
                        break;

                    case "FORGOT_REQUEST":
                        {
                            string email = parts[1];
                            string otp = await service.RequestPasswordReset(email);

                            if (otp != "EMAIL_NOT_FOUND")
                            {
                                EmailService mail = new EmailService();
                                await mail.SendOtp(email, otp);
                                response = "OTP_SENT";
                            }
                            else response = "EMAIL_NOT_FOUND";
                            break;
                        }

                    case "FORGOT_CONFIRM":
                        {
                            string email = parts[1];
                            string otp = parts[2];
                            string newPass = parts[3];

                            response = await service.ConfirmPasswordReset(email, otp, newPass);
                            break;
                        }

                    case "GET_LATEST_MOVIES":
                        if (parts.Length < 2 || !int.TryParse(parts[1], out int limitCount) || limitCount < 0)
                        {
                            response = "ERROR: GET_LATEST_MOVIES requires a non-negative integer limit parameter (e.g., GET_LATEST_MOVIES|100)";
                        }
                        else
                        {
                            response = await service.GetLatestMoviesRPC(limitCount);
                        }
                        break;





                    case "ADD_PHIM": // Them cai nay, xoa di cai case GetAvalableSlots di
                        {
                           
                            if (parts.Length < 14)
                            {
                                response = "ERROR: ADD_PHIM requires parameters up to denNgay (14 lines)";
                            }
                            else
                            {
                                string tenPhim = parts[1];
                                string theLoai = parts[2];
                                string doTuoi = parts[3];
                                int thoiLuong = int.Parse(parts[4]);
                                string moTa = parts[5];
                                string urlTrailer = parts[6];
                                string localPosterB64 = parts[7];  // client gửi base64 ảnh
                                string daoDien = parts[8];
                                string dienVien = parts[9];
                                string ngonNgu = parts[10];
                                string quocGia = parts[11];
                                DateTime tuNgay = DateTime.Parse(parts[12]);
                                DateTime denNgay = DateTime.Parse(parts[13]);

                                // GỌI FLOW MỚI: thêm phim + sinh lịch cố định
                                response = await service.AddPhimFullFlow(
                                    tenPhim, theLoai, doTuoi, thoiLuong, moTa,
                                    urlTrailer, localPosterB64, daoDien, dienVien,
                                    ngonNgu, quocGia, tuNgay, denNgay
                                );
                            }
                            break;
                        }


                    // ServerTCP.cs — trong switch(command)

                    case "GET_HISTORY": // Cai moi them
                        {
                            // Không cần tham số, lấy toàn bộ lịch sử
                            string json = await service.GetLichSuVeAllRPC();
                            response = string.IsNullOrWhiteSpace(json) ? "[]" : json;
                            break;
                        }


                    case "GET_MOVIES_LIST": // cai moi them
                        {
                            // Cho phép client truyền limit ở dòng 2, nếu không có thì mặc định 100
                            int limitcount = 100;
                            if (parts.Length >= 2 && int.TryParse(parts[1], out var n) && n >= 0)
                                limitcount = n;

                            // Gọi service (RPC Supabase) để lấy JSON danh sách phim
                            response = await service.GetMoviesListRPC(limitcount); // Trả về JSON array
                            break;
                        }



                    case "DELETE_MOVIE": // cai moi them
                        {
                            if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
                            {
                                response = "ERROR: DELETE_MOVIE requires IdPhim";
                            }
                            else
                            {
                                string idPhim = parts[1].Trim();
                                string rpcResult = await service.XoaPhimRPC(idPhim);

                                if (rpcResult == "SUCCESS")
                                    response = "OK: DELETED";
                                else
                                    response = rpcResult; // Trả về thông báo lỗi nếu có
                            }
                            break;
                        }

                    case "GET_STATS2": // Cai nay tui them // so 2 la cai chinh thuc
                        response = await service.GetCinemaStats2();
                        break;




                    case "CHECK_OTP":
                        {
                            string email = parts[1];
                            string otp = parts[2];
                            response = await service.CheckOtp(email, otp);
                            break;
                        }

                    case "GET_REVIEW_SUMMARY":
                        if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
                        {
                            response = "ERROR: GET_REVIEW_SUMMARY requires IdPhim (e.g., GET_REVIEW_SUMMARY|PHIM001)";
                        }
                        else
                        {
                            string idPhim = parts[1];
                            response = await service.GetReviewSummary(idPhim); //goi pthu ket hop 2 RCP da tao
                        }
                        break;

                    case "POST_REVIEW":
                        if (parts.Length < 5 || !int.TryParse(parts[4], out int soSao) || soSao < 1 || soSao > 5)
                        {
                            response = "ERROR: POST_REVIEW requires IdTaiKhoan|IdPhim|NoiDung|SoSao (1-5)";
                        }
                        else
                        {
                            string idTaiKhoan = parts[1];
                            string idPhim = parts[2];
                            string noiDung = parts[3];
                            response = await service.PostReview(idTaiKhoan, idPhim, noiDung, soSao);
                        }
                        break;

                    case "ADD_GIAMGIA": // Cai nay them o tron cai Handle file ServerTCP.cs
                        if (parts.Length < 5)
                        {
                            response = "ERROR: ADD_GIAMGIA requires IdGiamGia, TuNgay, DenNgay, TiLeGiam";
                        }
                        else
                        {
                            string id = parts[1];
                            if (!DateTime.TryParse(parts[2], out DateTime tuNgay) ||
                                !DateTime.TryParse(parts[3], out DateTime denNgay) ||
                                !decimal.TryParse(parts[4], out decimal tiLe))
                            {
                                response = "ERROR: Invalid date or numeric format";
                            }
                            else
                            {
                                response = await service.AddGiamGiaRPC(id, tuNgay, denNgay, tiLe);
                            }
                        }
                        break;

                    case "DELETE_REVIEW":
                        if (parts.Length < 2)
                            response = "ERROR: DELETE_REVIEW requires idReview";
                        else
                        {
                            string idReview = parts[1];
                            response = await service.DeleteReview(idReview);
                        }
                        break;
                    case "GET_VE_DADAT":
                        {
                            if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
                            {
                                response = "ERROR: GET_VE_DADAT requires IdTaiKhoan (e.g., GET_VE_DADAT|T003)";
                                break;
                            }

                            string idTaiKhoan = parts[1];
                            try
                            {
                                response = await service.GetVeDaDatRPC(idTaiKhoan);
                                response ??= "[]";
                            }
                            catch (Exception ex)
                            {
                                response = $"ERROR_GET_VE_DADAT: {ex.Message}";
                            }
                            break;
                        }
                    case "GET_PHIM_BY_ID":
                        if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
                        {
                            response = "ERROR: GET_PHIM_BY_ID requires IdPhim (e.g., GET_PHIM_BY_ID|P01)";
                        }
                        else
                        {
                            string idPhim = parts[1];
                            response = await service.GetPhimById(idPhim);
                        }
                        break;

                    case "GET_LICHCHIEU_CODINH":
                        if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
                        {
                            response = "ERROR: GET_LICHCHIEU_CODINH requires IdPhim (e.g., GET_LICHCHIEU_CODINH|P01)";
                        }
                        else
                        {
                            string idPhim = parts[1];
                            response = await service.GetLichChieuCoDinh(idPhim);
                        }
                        break;

                    case "GET_KHUNGGIO":
                        response = await service.GetKhungGio();
                        break;

                    case "GET_PHONGCHIEU":
                        response = await service.GetPhongChieu();
                        break;
                    case "ADD_HOLDSEAT":
                        {
                            if (parts.Length < 7) // cần đủ tham số
                            {
                                response = "ERROR: ADD_HOLDSEAT requires all parameters";
                            }
                            else
                            {
                                string idPhim = parts[1];
                                string idKhungGio = parts[2];
                                string idPhongChieu = parts[3];
                                DateTime ngayDat = DateTime.Parse(parts[4]);
                                string idGhe = parts[5];
                                string idTaiKhoan = parts[6];

                                response = await service.HoldSeatAsync(
                                    idPhim, idKhungGio, idPhongChieu, ngayDat, idGhe, idTaiKhoan);
                            }
                            break;
                        }
                    case "SET_VE":
                        {
                            if (parts.Length < 9)
                            {
                                response = "ERROR: SET_VE requires all parameters";
                            }
                            else
                            {
                                string idPhim = parts[1];
                                string idKhungGio = parts[2];
                                string idPhongChieu = parts[3];
                                DateTime ngayDat = DateTime.Parse(parts[4]);
                                string idGhe = parts[5];
                                string idTaiKhoan = parts[6];
                                decimal giaVe = decimal.Parse(parts[7]);
                                string idThanhToan = parts[8]; 

                                response = await service.SetVeAsync(
                                    idPhim, idKhungGio, idPhongChieu, ngayDat,
                                    idGhe, idTaiKhoan, giaVe, idThanhToan);
                            }
                            break;
                        }

                    case "GET_SEATSTATUS":
                        {
                            if (parts.Length < 5)
                            {
                                response = "ERROR: GET_SEATSTATUS requires parameters";
                            }
                            else
                            {
                                string idPhim = parts[1];
                                string idKhungGio = parts[2];
                                string idPhongChieu = parts[3];
                                DateTime ngayDat = DateTime.Parse(parts[4]);

                                response = await service.GetSeatStatusAsync(idPhim, idKhungGio, idPhongChieu, ngayDat);
                            }
                            break;
                        }
                    case "REMOVE_HOLDSEAT":
                        {
                            if (parts.Length < 7)
                            {
                                response = "ERROR: REMOVE_HOLDSEAT requires all parameters";
                            }
                            else
                            {
                                string idPhim = parts[1];
                                string idKhungGio = parts[2];
                                string idPhongChieu = parts[3];
                                DateTime ngayDat = DateTime.Parse(parts[4]);
                                string idGhe = parts[5];
                                string idTaiKhoan = parts[6];

                                response = await service.RemoveHoldSeatAsync(
                                    idPhim, idKhungGio, idPhongChieu, ngayDat, idGhe, idTaiKhoan);
                            }
                            break;
                        }
                    case "CHECK_PAYMENT":
                        {
                            if (parts.Length < 2)
                            {
                                response = "ERROR: CHECK_PAYMENT requires IdThanhToan";
                            }
                            else
                            {
                                string idThanhToan = parts[1];
                                response = await service.CheckPaymentAsync(idThanhToan);
                            }
                            break;
                        }
                    case "DELETE_TICKET":
                        {
                            if (parts.Length < 7)
                            {
                                response = "ERROR: DELETE_TICKET requires all parameters";
                            }
                            else
                            {
                                string idPhim = parts[1];
                                string idKhungGio = parts[2];
                                string idPhongChieu = parts[3];
                                DateTime ngayDat = DateTime.Parse(parts[4]);
                                string idGhe = parts[5];
                                string idTaiKhoan = parts[6];

                                response = await service.DeleteTicketAsync(
                                    idPhim, idKhungGio, idPhongChieu, ngayDat, idGhe, idTaiKhoan);
                            }
                            break;
                        }
                    case "GET_GIAMGIA":
                        {
                            if (parts.Length < 2)
                            {
                                response = "ERROR: GET_GIAMGIA requires IdGiamGia";
                            }
                            else
                            {
                                string idGiamGia = parts[1];
                                response = await service.GetGiamGiaAsync(idGiamGia);
                            }
                            break;
                        }

                    case "GET_GIAMGIA_STAT":
                        {
                            try
                            {
                                string json = await service.GetGiamGiaRPC();
                                response = json ?? "[]";
                            }
                            catch (Exception ex)
                            {
                                response = $"ERROR_GET_GIAMGIA: {ex.Message}";
                            }
                            break;
                        }

                    case "SET_GIAMGIA_TAIKHOAN":
                        {
                            if (parts.Length < 3)
                            {
                                response = "ERROR: SET_GIAMGIA_TAIKHOAN requires IdGiamGia|IdTaiKhoan";
                            }
                            else
                            {
                                string idGiamGia = parts[1];
                                string idTaiKhoan = parts[2];

                                response = await service.SetGiamGiaTaiKhoanAsync(idGiamGia, idTaiKhoan);
                            }
                            break;
                        }
                    case "UNSET_GIAMGIA_TAIKHOAN":
                        {
                            if (parts.Length < 3)
                            {
                                response = "ERROR: UNSET_GIAMGIA_TAIKHOAN requires IdGiamGia|IdTaiKhoan";
                            }
                            else
                            {
                                string idGiamGia = parts[1];
                                string idTaiKhoan = parts[2];

                                response = await service.UnsetGiamGiaTaiKhoanAsync(idGiamGia, idTaiKhoan);
                            }
                            break;
                        }
                    case "REMOVE_THANHTOAN_BAPNUOC":
                        {
                            if (parts.Length < 2)
                            {
                                response = "ERROR: REMOVE_THANHTOAN_BAPNUOC requires IdThanhToan";
                            }
                            else
                            {
                                string idThanhToan = parts[1];
                                response = await service.RemoveThanhToanBapNuocAsync(idThanhToan);
                            }
                            break;
                        }

                    case "ADD_THANHTOAN_BAPNUOC":
                        {
                            if (parts.Length < 7)
                            {
                                response = "ERROR";
                            }
                            else
                            {
                                string idThanhToan = parts[1];
                                string idTaiKhoan = parts[2];
                                string idBapNuoc = parts[3];
                                decimal tongtien = decimal.Parse(parts[4]);
                                string trangthai = parts[5];
                                DateTime ngaydat = DateTime.Parse(parts[6]);
                                response = await service.AddThanhToanBapNuocAsync(idThanhToan, idTaiKhoan, idBapNuoc,tongtien,trangthai,ngaydat);
                            }
                            break;
                        }
                    case "SET_GIAMGIA":
                        {
                            if (parts.Length < 2)
                            {
                                response = "ERROR";
                            }
                            else
                            {
                                string idGiamGia = parts[1];
                                response = await service.SetGiamGiaAsync(idGiamGia);
                            }
                            break;
                        }
                    case "UNSET_GIAMGIA":
                        {
                            if (parts.Length < 2)
                            {
                                response = "ERROR";
                            }
                            else
                            {
                                string idGiamGia = parts[1];
                                response = await service.UnsetGiamGiaAsync(idGiamGia);
                            }
                            break;
                        }
                    default:
                        response = "UNKNOWN_COMMAND";
                        break;
                }

                await SendResponseAsync(stream, response);
                Console.WriteLine($"Gui: {response.Trim()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi xu ly client: {ex}");
            }
        }

        private async Task SendResponseAsync(NetworkStream stream, string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            int length = messageBytes.Length;

            byte[] lengthBytes = BitConverter.GetBytes(length);

            await stream.WriteAsync(lengthBytes, 0, lengthBytes.Length);

            await stream.WriteAsync(messageBytes, 0, messageBytes.Length);
        }
    }
}