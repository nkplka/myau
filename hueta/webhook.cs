namespace hueta;

public static class Webhook
{
    private static readonly HttpClient Client = new();

    private static async Task SendWebhook(string url, string message)
    {
        var values = new Dictionary<string, string> { { "content", message } };
        var content = new FormUrlEncodedContent(values);
        await Client.PostAsync(url, content);
    }

    public static async Task Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("menu:");
            Console.WriteLine("1. send message");
            Console.WriteLine("2. exit");
            Console.Write("Enter choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("enter webhook link: ");
                    var url = Console.ReadLine();

                    Console.Write("enter message to send: ");
                    var message = Console.ReadLine();

                    try
                    {
                        await SendWebhook(url, message);
                        Console.WriteLine("successfully.");
                        Console.ReadKey();
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"errrr sending message: {ex.Message}");
                        Console.ReadKey();
                        
                    }

                    break;

                case "2":
                    return;

                default:
                    Console.WriteLine("invalid choice!");
                    break;
            }

            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Program.Main();
        }
    }
}