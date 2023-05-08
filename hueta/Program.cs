using hueta;

internal class Program
{
    public static void Main()
    {
        Console.Title = "debug menu";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("main menu:");
            Console.WriteLine("1. minecraft parser");
            Console.WriteLine("2. discord webhook");
            Console.WriteLine("3. task manager");
            Console.WriteLine("4. kdmapper");
            Console.WriteLine("5. stop faceit");
            Console.WriteLine("h. help menu");
            Console.WriteLine("0. exit");
            Console.WriteLine("number: ");


            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Minecraft.ParseServer();
                    break;

                case "2":
                    Webhook.Menu();
                    break;

                case "3":
                    Taskmgr.Manager();
                    break;

                case "4":
                    kdmapper.startdriver();
                    break;

                case "5":
                    faceit.stop();
                    break;

                case "test":
                    tests.test();
                    break;

                case "h":
                    Help.Menu();
                    break;

                case "777":
                    ptn.Ptn();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}