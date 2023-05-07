using System.Diagnostics;
using System;
namespace hueta;

public class faceit
{
    public static void stop()
    {
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = "/c start /wait cmd.exe /c sc stop faceit";
        process.Start();
    }
    
}