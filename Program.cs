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
            Process.Start("explorer.exe");
            IntPtr MyHwnd = WinAPI.FindWindowA(null, "File Explorer");

            //using that handle to set the window name
            WinAPI.SetWindowTextA(MyHwnd, "Test");

            Console.ReadKey();
        }

        static void PerformSearch()
        {


        }
    }
}
