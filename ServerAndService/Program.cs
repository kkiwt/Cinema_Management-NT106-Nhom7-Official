using System;
using System.Threading.Tasks;

namespace ServerAndService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var server = new ServerTCP();
            await server.StartAsync(5000);
        }

    }
}
