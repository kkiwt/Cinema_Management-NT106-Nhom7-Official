// ===========================
// File: ClientTCP.cs
// ===========================
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement
{
    internal class ClientTCP
    {
        private readonly string _host;
        private readonly int _port;

        public ClientTCP(string host = "127.0.0.1", int port = 5000)
        {
            _host = host;
            _port = port;
        }

        public async Task<string> SendMessageAsync(string message)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync(_host, _port);
                    var stream = client.GetStream();

                    byte[] data = Encoding.UTF8.GetBytes(message);
                    await stream.WriteAsync(data, 0, data.Length);

                    byte[] buffer = new byte[8192];
                    int bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytes);
                    client.Close();
                    response = response
                        .Replace("\0", "")
                        .Replace("\r", "")
                        .Replace("\n", "")
                        .Trim();
                    return response;


                }
            }
            catch (Exception ex)
            {
                return $"ERROR: {ex.Message}";
            }
        }
    }
}
