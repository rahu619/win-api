using System;
using System.Runtime.InteropServices;

namespace windows.search
{
    public class WinAPI
    {
        [DllImport("User32.dll")]
        public static extern bool SetWindowTextA(IntPtr hWnd, string lpString);

        [DllImport("User32.dll")]
        public static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

        //[DllImport("User32.dll")]
        //public static extern IntPtr FindTextA(LPFINDREPLACEA unnamedParam1);

    }
}
