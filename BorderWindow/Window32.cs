//using System;
//using System.Runtime.InteropServices;
//using static Tools.WinApi;

//namespace Tools.Module
//{
//    class Window32
//    {
        

//        public Window32()
//        {
//            WNDCLASSEX wind_class = new WNDCLASSEX();
//            wind_class.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
//            wind_class.style = (int)(CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS); //Doubleclicks are active
//            wind_class.hbrBackground = (IntPtr)COLOR_BACKGROUND + 1; //Black background, +1 is necessary
//            wind_class.cbClsExtra = 0;
//            wind_class.cbWndExtra = 0;
//            wind_class.hInstance = Marshal.GetHINSTANCE(this.GetType().Module); ;// alternative: Process.GetCurrentProcess().Handle;
//            wind_class.hIcon = IntPtr.Zero;
//            wind_class.hCursor = LoadCursor(IntPtr.Zero, (int)IDC_CROSS);// Crosshair cursor;
//            wind_class.lpszMenuName = null;
//            wind_class.lpszClassName = "myClass";
//            wind_class.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(delegWndProc);
//            wind_class.hIconSm = IntPtr.Zero;
//            ushort regResult = RegisterClassEx(ref wind_class);


//        }
//    }
//}
