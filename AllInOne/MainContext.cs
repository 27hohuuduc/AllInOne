using System;
using System.Windows.Forms;
using AllInOne.module;
using System.Runtime.InteropServices;

namespace AllInOne
{
    // Create Window Reference:https://gist.github.com/AlexanderBaggett/d1504da93727a1778e8b5b3453946fc1
    class MainContext : ApplicationContext
    {
        public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
        public delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        private static IntPtr m_timer_id;

        public MainContext()
        {
            var className = "DUCHO";
            WNDCLASSEX wcex = new WNDCLASSEX();
            wcex.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
            wcex.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(
                (WndProcDelegate)((window, message, wparam, lparam) =>
                {
                    var thisRef = Api32.GetWindowLongPtr(window, (-21)); //GWL_USERDATA
                    if (thisRef == IntPtr.Zero && message == 0x0001)
                    {
                        var createStruct = (CREATESTRUCTA)Marshal.PtrToStructure(lparam, typeof(CREATESTRUCTA));
                        thisRef = createStruct.lpCreateParams;
                        Api32.SetWindowLongPtr(window, (-21), thisRef);//GWL_USERDATA
                    }
                    //return (thisRef != IntPtr.Zero) ? 
                    return Api32.DefWindowProc(window, message, wparam, lparam);
                }
            ));
            wcex.hInstance = System.Diagnostics.Process.GetCurrentProcess().Handle;
            wcex.lpszClassName = className;
            wcex.hCursor = Api32.LoadCursor(IntPtr.Zero, 32512);
            Api32.RegisterClassEx(ref wcex);

            var m_window = Api32.CreateWindowEx(
                0x00080000 | 0x00000008 | 0x00000080
                , className
                , ""
                , 0x80000000u | 0x8000000
                , 0
                , 0
                , 600
                , 300
                , IntPtr.Zero
                , IntPtr.Zero
                , System.Diagnostics.Process.GetCurrentProcess().Handle
                , IntPtr.Zero);
            Api32.ShowWindow(m_window, 8); //SW_SHOWNA
        }

        //public IntPtr WndProc(IntPtr window, uint message, uint wparam, IntPtr lparam)
        //{
        //    if (message == 0x0113)
        //    {
        //        if (wparam == 123)
        //        {
        //            KillTimer
        //        }
        //    }
        //}
    }
}
