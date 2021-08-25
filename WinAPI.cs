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

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, uint wParam, int lParam);


        [DllImport("shell32.dll")]
        public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, ShowCommands nShowCmd);

        public enum ShowCommands : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }


    }

}
