namespace MyWebServer
{
    using MyWebServer.Server;
    using System.Threading.Tasks;

    class Startup
    {
        public static async Task Main()
        {
            HttpServer server = new HttpServer("127.0.0.1", 8080);

            await server.Start();
        }
    }
}
