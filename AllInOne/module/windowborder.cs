using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne.module
{
    class windowborder
    {
        private IntPtr m_window;
        private IntPtr m_trackingWindow;
        private IntPtr m_frameDrawer;

        public windowborder(IntPtr window)
        {
            m_window = IntPtr.Zero;
            m_trackingWindow = IntPtr.Zero;
            m_frameDrawer = IntPtr.Zero;
        }
    }
}
