using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SecurityBenchmarkingTool.Executors
{ 
class CommandExecutor
{
    public static void ExecuteCommand(string command)
    {
        int exitCode;
        ProcessStartInfo processInfo;
        Process process;

        processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
        processInfo.CreateNoWindow = true;
        processInfo.UseShellExecute = false;
        processInfo.Verb = "runas";
        // *** Redirect the output ***
        processInfo.RedirectStandardError = true;
        processInfo.RedirectStandardOutput = true;

        process = Process.Start(processInfo);
        process.WaitForExit();

        // *** Read the streams ***
        // Warning: This approach can lead to deadlocks, see Edit #2
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        exitCode = process.ExitCode;

        Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
        Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
        Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
        process.Close();
    }


    public static string ExecuteCommandR(string command)
    {
        int exitCode;
        ProcessStartInfo processInfo;
        Process process;

        processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
        processInfo.CreateNoWindow = true;
        processInfo.UseShellExecute = false;
        processInfo.Verb = "runas";
        // *** Redirect the output ***
        processInfo.RedirectStandardError = true;
        processInfo.RedirectStandardOutput = true;

        process = Process.Start(processInfo);
        process.WaitForExit();

        // *** Read the streams ***
        // Warning: This approach can lead to deadlocks, see Edit #2
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        exitCode = process.ExitCode;

        Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
        Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
        Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
        process.Close();

        /*            if(output != "(none)")
                    {
                        String[] spearator = { "\n" };
                        string[] sp = { "    " };
                        string[] oupt = output.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                        string t = oupt[0];
                        string[] r = t.Split(sp, StringSplitOptions.RemoveEmptyEntries);
                        if(r.Length == 2)
                        {
                            output = r[2];
                        }

                    }*/

        return (String.IsNullOrEmpty(output) ? "(none)" : output);
    }
}
}
