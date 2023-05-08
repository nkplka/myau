using System.Diagnostics;

namespace hueta;

public class kdmapper
{
    public static void startdriver()
    {
        Console.Write("Введите путь к драйверу: ");
        var driverPath = Console.ReadLine();

        // Проверяем, что файл существует по указанному пути
        if (!File.Exists(driverPath))
        {
            Console.WriteLine($"Файл {driverPath} не найден.");
            Console.ReadKey();
        }

        Process.Start("C:\\Program Files (x86)\\AvastSoftare\\kdmapper.exe", driverPath);
        Console.ReadKey();
        Program.Main();
    }
}