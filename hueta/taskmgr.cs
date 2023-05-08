using System.Diagnostics;

namespace hueta;

public class Taskmgr
{
    public static void Manager()
    {
        static void Tasks()
        {
            var processes = Process.GetProcesses();

            foreach (var process in processes)
                Console.WriteLine("Process Name: {0} | Process ID: {1}", process.ProcessName, process.Id);

            Console.ReadLine();
        }

        static void CloseProcess()
        {
            Tasks();
            Console.Write("Enter process ID: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var id))
                try
                {
                    var process = Process.GetProcessById(id);
                    process.Kill();
                    Console.WriteLine($"Process {id} was successfully killed.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Process {id} was not found: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error closing process {id}: {ex.Message}");
                }
            else
                Console.WriteLine("Invalid input. Please enter a valid process ID.");
        }


        while (true)
        {
            Console.Clear();
            Console.WriteLine("main menu:");
            Console.WriteLine("1. process list");
            Console.WriteLine("2. close process");
            Console.WriteLine("0. exit");
            Console.Write("number: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Tasks();
                    break;

                case "2":
                    CloseProcess();
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