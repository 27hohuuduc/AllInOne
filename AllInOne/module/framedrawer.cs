using System;
using static AllInOne.module.Api32;
using System.Runtime.InteropServices;

namespace AllInOne.module
{
    class framedrawer
    {
        private IntPtr m_window;

        public framedrawer(IntPtr window)
        {
            m_window = window;
        }

        uint D2DRectUHash(D2D1_SIZE_U rect)
        {
            Marshal.
            using pod_repr_t = U
        }

        public static IntPtr Create(IntPtr window)
        {
            var seft = new framedrawer(window);
            if (seft.Init())
            {
                return seft.m_window;
            }

            return IntPtr.Zero;

        }

        private void Init()
        {

        }

        private void CreateRenderTargets(ref Rectangle clientRect)
        {
            ID2D1Factory 
        }
    }
}
