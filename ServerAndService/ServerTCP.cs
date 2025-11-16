// ===========================
// File: ServerTCP.cs
// ===========================
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
                var buffer = new byte[4096];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                Console.WriteLine($"Nhan: {message}");

                // 🔹 Kiểm tra dữ liệu rỗng
                if (string.IsNullOrWhiteSpace(message))
                {
                    await SendResponseAsync(stream, "ERROR: Empty message received");
                    return;
                }

                // 🔹 Tách phần command
                string[] parts = message.Split('|');
                if (parts.Length == 0)
                {
                    await SendResponseAsync(stream, "ERROR: Invalid message format");
                    return;
                }

                string command = parts[0].ToUpper();
                string response;

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
            string responseWithDelimiter = message;
            byte[] respBytes = Encoding.UTF8.GetBytes(responseWithDelimiter);

            await stream.WriteAsync(respBytes, 0, respBytes.Length);
        }
    }
}
