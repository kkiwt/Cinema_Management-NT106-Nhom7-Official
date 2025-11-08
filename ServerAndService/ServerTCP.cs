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
        private TcpListener _listener;
        private Service _service;

        public ServerTCP()
        {
            _service = new Service();
        }

        public async Task StartAsync(int port = 5000)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            Console.WriteLine($"Server dang chay tai cong {port}...");

            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                _ = HandleClientAsync(client);
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                Console.WriteLine("Client moi ket noi.");
                var stream = client.GetStream();
                var buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                Console.WriteLine($"Nhan: {message}");

                string[] parts = message.Split('|');
                string command = parts[0];
                string response ;

                switch (command.ToUpper())
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
                            DateTime ngaySinh;
                            string soDienThoai = parts[7];

                            if (!DateTime.TryParse(parts[6], out ngaySinh))
                            {
                                response = "ERROR: Invalid date format";
                                break;
                            }

                            response = await _service.RegisterUser(hoTen, username, password, email, gioiTinh, ngaySinh, soDienThoai);
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
                            response = await _service.LoginUser(username, password);
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
                Console.WriteLine($"Loi xu ly client: {ex.Message}");
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
