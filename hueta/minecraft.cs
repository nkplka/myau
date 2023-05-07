using System.Net;
using Newtonsoft.Json;

namespace hueta;

public class Minecraft
{
    public static void ParseServer()
    {
        Console.Clear();
        Console.WriteLine("Enter server address (example - mc.example.ru):");

        var url = Console.ReadLine();

        var apiUrl = $"https://api.mcsrvstat.us/2/{url}";

        using (var webClient = new WebClient())
        {
            try
            {
                var jsonData = webClient.DownloadString(apiUrl);
                var result = JsonConvert.DeserializeObject<dynamic>(jsonData);

                if (result.online == true)
                {
                    Console.WriteLine("IP: " + result.ip);
                    Console.WriteLine("Port: " + result.port);
                    Console.WriteLine("Players Online: " + result.players.online);
                    Console.WriteLine("Version: " + result.version);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("offline.");
                    Console.WriteLine("press enter to continue.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("errr: " + ex.Message);
                Console.WriteLine("press enter to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}