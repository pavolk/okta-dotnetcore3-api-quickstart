using Webapi;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();

            try {
                var c = new Client("https://localhost:5001", httpClient);
                var result = c.HelloAsync().GetAwaiter().GetResult();
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}