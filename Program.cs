using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
//using Microsoft.Windows.


namespace windows.search
{
    class Program
    {
        static void Main(string[] args)
        {
            //opening up a new explorer window
            //Process.Start("explorer.exe");

            IntPtr MyHwnd = WinAPI.FindWindowA(null, "File Explorer");

            ////using that handle to set the window name
            WinAPI.SetWindowTextA(MyHwnd, "Test Title");

            //Process.Start(srch);


            //WinAPI.ShellExecute(MyHwnd, "open", "explorer.exe", @"C:\Repos\aiconomix\windows.search", null, WinAPI.ShowCommands.SW_NORMAL);

            //WinAPI.ShellExecute(IntPtr.Zero, "explore", @"C:\Repos\aiconomix\windows.search", null, null, WinAPI.ShowCommands.SW_NORMAL);

            //WinAPI.ShellExecute(IntPtr.Zero, "explore", @"C:\Repos\aiconomix\windows.search", null, null, WinAPI.ShowCommands.SW_NORMAL);

            WinAPI.ShellExecute(MyHwnd, "find", @"C:\Repos\aiconomix\windows.search", null, null, WinAPI.ShowCommands.SW_HIDE);
            //ShellExecute(handle, "find", < fully_qualified_path_to_folder >, NULL, NULL, 0);
            //var shellApplication = Type.GetTypeFromProgID("Shell.Application");
            //dynamic shell = Activator.CreateInstance(shellApplication);
            //shell.Open(@"C:\Repos\");

            Console.ReadKey();
        }

 

    }
}
