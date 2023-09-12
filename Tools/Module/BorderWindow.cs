using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static Tools.WinApi;


namespace Tools.Module
{
    using result_t = List<IntPtr>;

    class BorderWindow
    {
        //        static readonly uint PROCESS_QUERY_INFORMATION = 0x0400;
        //        static readonly uint PROCESS_VM_READ = 0x0010;
        //        static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        //        static readonly int MAX_PATH = 260;

        //        StringBuilder get_process_path(uint pid)
        //        {
        //            var process = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, true, pid);
        //            StringBuilder name = new StringBuilder(MAX_PATH);

        //            if(process != INVALID_HANDLE_VALUE)
        //            {
        //                int name_lenght = name.Length;
        //                if (QueryFullProcessImageName(process, 0, name, ref name_lenght) == false)
        //                {
        //                    name_lenght = 0;
        //                }
        //                name.Length = name_lenght;
        //                CloseHandle(process);
        //            }
        //            return name;
        //        }

        //        StringBuilder get_process_path(IntPtr window)
        //        {
        //            const string app_frame_host = "ApplicationFrameHost.exe";

        //            uint pid;
        //            GetWindowThreadProcessId(window, out pid);
        //            var name = get_process_path(pid);

        //            if (name.Length >= app_frame_host.Length && name.Equals(app_frame_host)) {
        //                uint new_pid = pid;
        //                EnumWindowsProc enumWindowsProc = (IntPtr hwnd, IntPtr lParam) =>
        //                {
        //                    GCHandle gch = GCHandle.FromIntPtr(lParam);
        //                    var new_pid_ptr = Convert.ToUInt32(gch.Target);
        //                    uint pidlocal;

        //                    GetWindowThreadProcessId(hwnd, out pidlocal);

        //                    if (pidlocal != new_pid_ptr)
        //                    {
        //                        new_pid_ptr = pid;
        //                        return false;
        //                    }
        //                    else
        //                        return true;
        //                };
        //                EnumChildWindows(window, enumWindowsProc, new IntPtr(new_pid));

        //                if (new_pid != pid)
        //                    return get_process_path(new_pid);
        //            }

        //            return name;
        //        }

        //        bool find_app_name_in_path(StringBuilder where, Dictionary<IntPtr, String> what)
        //        {
        //            foreach (var row in what)
        //            {
        //                var pos = where.ToString().(row);
        //                const auto last_slash = where.rfind('\\');
        //                //Check that row occurs in where, and its last occurrence contains in itself the first character after the last backslash.
        //                if (pos != std::wstring::npos && pos <= last_slash + 1 && pos + row.length() > last_slash)
        //                {
        //                    return true;
        //                }
        //            }
        //            return false;
        //        }

        //bool check_excluded_app(IntPtr hwnd, StringBuilder processPath, Dictionary<IntPtr, String> excludedApps)
        //        {
        //            bool res = find_app_name_in_path(processPath, excludedApps);

        //            if (!res)
        //            {
        //                res = check_excluded_app_with_title(hwnd, processPath, excludedApps);
        //            }

        //            return res;
        //        }

        //bool isExcluded(IntPtr window)
        //        {
        //            var processPath = get_process_path(window);
        //            CharUpperBuffW(processPath, Convert.ToUInt32(processPath.Length));

        //            return check_excluded_app(window, processPath, AlwaysOnTopSettings::settings().excludedApps);
        //        }




        public BorderWindow()
        {
            //result_t result = new List<IntPtr>();

            //EnumWindowsProc enumWindows = (IntPtr hWnd, IntPtr lParam) =>
            //{
            //    if (!IsWindowVisible(hWnd))
            //    {
            //        return true;
            //    }

            //    //if (isExcluded(hwnd))
            //    //{
            //    //    return true;
            //    //}

            //    var windowName = GetWindowTextLength(hWnd);
            //    if (windowName > 0)
            //    {
            //        GCHandle gch = GCHandle.FromIntPtr(lParam); ;
            //        result_t resultlocal = gch.Target as result_t;
            //        resultlocal.Add(hWnd);
            //    }

            //    return true;
            //};

            //EnumWindows(enumWindows, GCHandle.ToIntPtr(GCHandle.Alloc(result)));

            //foreach (var window in result)
            //{
            //    if (IsP)
            //}


        }
    }
}
