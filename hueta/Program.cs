using hueta;
using System;
using System.Diagnostics;
using System.Security.Principal;


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
            Console.WriteLine("5. stop faceit driver");
            Console.WriteLine("0. exit");
            Console.Write("number: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

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