// ServerTCP.cs
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

        public async Task StartAsync(int port = 5000)
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
                    case "GET_REVIEW_SUMMARY":
                        if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
                        {
                            response = "ERROR: GET_REVIEW_SUMMARY requires IdPhim (e.g., GET_REVIEW_SUMMARY|PHIM001)";
                        }
                        else
                        {
                            string idPhim = parts[1];
                            response = await service.GetReviewSummary(idPhim); //goi pthu kethop 2 RCP da tao
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