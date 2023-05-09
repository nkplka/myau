using System;
using System.Diagnostics;

namespace hueta;

public class chatgpt
{
    public static void chat()
    {


        string exePath = "chatgpt.exe";

        // Создаем новый процесс и задаем свойства
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = exePath, // Путь к .exe файлу
            UseShellExecute = true, // Запускаем процесс через оболочку Windows
            Verb = "open" // Открываем файл с помощью программы по умолчанию
        };

        // Запускаем процесс
        try
        {
            Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка запуска процесса: " + ex.Message);
        }
    }
}
