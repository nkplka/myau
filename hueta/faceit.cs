using System.Diagnostics;

namespace hueta;

public class faceit
{
    public static void stop()
    {
        var process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = "/c start /wait cmd.exe /c sc stop faceit";
        process.Start();
    }
}