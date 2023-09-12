using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tools
{
    public class TrayApplicationContext : ApplicationContext
    {
        public ContextMenuStrip ContextMenu { get; private set; }

        public NotifyIcon NotifyIcon { get; private set; }

        /// <summary>
        /// Create a Menu Context
        /// </summary>
        /// <param name="icon"></param>
        public TrayApplicationContext(Icon icon)
        {
            ContextMenu = new ContextMenuStrip();
            NotifyIcon = new NotifyIcon()
            {
                Text = Application.ProductName,
                Icon = icon,
                ContextMenuStrip = ContextMenu,
                Visible = true
            };
            NotifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            Application.ApplicationExit += Application_ApplicationExit;
        }

        /// <summary>
        /// Event Double click
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnNotifyIconDoubleClick(EventArgs e) { }

        protected virtual void OnApplicationExit(EventArgs e) { }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnNotifyIconDoubleClick(e);
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            OnApplicationExit(e);
            if (ContextMenu != null)
                ContextMenu.Dispose();
            if (NotifyIcon != null)
            {
                NotifyIcon.Visible = false;
                NotifyIcon.Dispose();
            }
        }
    }
}
