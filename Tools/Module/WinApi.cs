using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using HANDLE = System.IntPtr;

namespace Tools
{
    class WinApi
    {



        /// <summary>
        /// Cursor for callback
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);


        /// <summary>
        /// Get all Windows
        /// </summary>
        /// <param name="lpEnumFunc"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// True when window is visibled
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint GetWindowThreadProcessId([In] IntPtr hWnd, [Out] out uint lpdwProcessId);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, uint processId);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] int dwFlags, [Out] StringBuilder lpExeName, ref int lpdwSize);

        [DllImport("coredll.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(HANDLE hObject);

        public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint CharUpperBuffW([In, Out] StringBuilder lpsz, uint cchLength);




        /// <summary>
        /// Get hWnd of current window
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern IntPtr GetShellWindow();


        [DllImport("user32.dll")]
        private static extern long GetWindowLong(IntPtr hWnd, int nIndex);
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TOPMOST = 0x00000008;
        public static bool fCheckWindowTopmost(IntPtr hWnd)
        {
            long val = GetWindowLong(hWnd, GWL_EXSTYLE);
            return (val & WS_EX_TOPMOST) != 0;
        }


        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private const int SWP_DRAWFRAME = 0x0020;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOSIZE = 0x0001;
        /// <summary>
        /// Set on top most
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="topmost"></param>
        /// <returns>true if success or false if fails</returns>
        public static bool fWindowTopmost(IntPtr hWnd, bool topmost)
        {
            IntPtr mode = topmost ? /* HWND_TOPMOST */ (IntPtr)(-1)
                                : /* HWND_NOTOPMOST */ (IntPtr)(-2);
            return SetWindowPos(hWnd, mode, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_DRAWFRAME);
        }


        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        /// <summary>
        /// Get Current Input Window
        /// </summary>
        public static IntPtr fGetForegroundWindow
        {
            get => GetForegroundWindow();
        }


        [DllImport("user32.dll")]
        private static extern uint GetFrameRect(int nIndex);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct WNDCLASSEX
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public int style;
            public IntPtr lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public IntPtr hInstance;
            public IntPtr hIcon;
            public IntPtr hCursor;
            public IntPtr hbrBackground;
            public string lpszMenuName;
            public string lpszClassName;
            public IntPtr hIconSm;
        }

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "RegisterClassEx")]
        public static extern System.UInt16 RegisterClassEx([In] ref WNDCLASSEX lpWndClass);


        #region Example

        /// <summary>
        /// Get name of window be app
        /// </summary>
        /// <returns></returns>
        public static Dictionary<IntPtr, string> GetWindowHandles()
        {
            //Get String Shell Ex:0x00010102
            IntPtr shellWindow = GetShellWindow();
            Dictionary<IntPtr, string> handles = new Dictionary<IntPtr, string>();
            EnumDelegate callback = (IntPtr hWnd, int lParam) =>
            {
                //Skip current window or don't visiable
                if (hWnd == shellWindow || !IsWindowVisible(hWnd)) return true;

                //Skip chill windows
                int length = GetWindowTextLength(hWnd);
                if (length == 0) return true;

                //get name window
                StringBuilder sb = new StringBuilder(length + 1);
                GetWindowText(hWnd, sb, sb.Capacity);

                handles.Add(hWnd, sb.ToString());
                return true;
            };
            //EnumWindows(callback, IntPtr.Zero);
            return handles;
        }

        #endregion
    }
}
