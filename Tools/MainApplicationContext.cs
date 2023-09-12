using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Tools.Properties;
using Bluegrams.Windows.Tools;
using Bluegrams.Application.WinForms;
using Window32;
//using Tools.Module;

namespace Tools
{
    public class MainApplicationContext: TrayApplicationContext
    {
        private bool notify = true;

        #region HotKey
        private GlobalHotKey _KeySelectWindow;
        public GlobalHotKey KeySelectWindow { get => _KeySelectWindow; }
        public KeyCombination SetKeySelectWindow { set
            {
                _KeySelectWindow = RegisterHotKey.SetHotKey(_KeySelectWindow, value, (GlobalHotKey _) => selectWindowFromScreen());
            } }

        private GlobalHotKey _KeyCurrentShell;
        public GlobalHotKey KeyCurrentShell { get => _KeyCurrentShell; }
        public KeyCombination SetKeyCurrentShell
        {
            set
            {
                _KeyCurrentShell = RegisterHotKey.SetHotKey(_KeyCurrentShell, value, (GlobalHotKey _) => {
                    IntPtr window = WinApi.fGetForegroundWindow;
                    WinApi.fWindowTopmost(window, !WinApi.fCheckWindowTopmost(window));
                });
            }
        }

        #endregion

        /// <summary>
        /// Run on background
        /// </summary>
        public MainApplicationContext() : base(Resources.PinWinIconWhite)
        {
            if (Settings.Default.KeySelectWindow != Keys.None)
            {
                //Set key
                SetKeySelectWindow = (KeyCombination)Settings.Default.KeySelectWindow;
            }

            if (Settings.Default.KeyGetShell != Keys.None)
            {
                //Set key
                SetKeyCurrentShell = (KeyCombination)Settings.Default.KeyGetShell;
            }

            ContextMenu.Opening += ContextMenu_Opening;

            Application.ApplicationExit += Application_ApplicationExit;

            new BorderWindow();
        }

        private void selectWindowFromScreen()
        {
            if (notify)
            {
                NotifyIcon.BalloonTipText = "Select a window from screen to pin it on top. Press 'Esc' to exit.";
                NotifyIcon.ShowBalloonTip(1);
                notify = false;
            }
            var overlay = new OverlayForm();
            overlay.TopMost = true;
            if (overlay.ShowDialog() == DialogResult.OK)
            {
                WinApi.fWindowTopmost(overlay.SelectionHandle, true);
            }
        }

        /// <summary>
        /// active when ContextMenu is opening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ContextMenu.Items.Clear();

            var windowsItems = new List<ToolStripMenuItem>();
            foreach (var kv in WinApi.GetWindowHandles())
            {
                bool topmost = WinApi.fCheckWindowTopmost(kv.Key);
                string truncated = kv.Value.Substring(0, Math.Min(kv.Value.Length, Settings.Default.TitleLengthLimit));
                windowsItems.Add(new ToolStripMenuItem(truncated, null,
                    (o, args) => WinApi.fWindowTopmost(kv.Key, !topmost))
                {
                    Checked = topmost,
                    ToolTipText = kv.Value
                });
            };

            var generalItems = new List<ToolStripMenuItem>()
            {
                new ToolStripMenuItem("Select Window From Screen", Resources.TargetIcon, onSelectWindowClicked)
                { ShortcutKeyDisplayString = KeySelectWindow?.KeyCombination.ToString() },
                new ToolStripMenuItem("Unpin All Windows", Resources.DeleteIcon, onUnpinAllClicked),
                new ToolStripMenuItem("Options", Resources.OptionsIcon, onOptionsClicked),
                new ToolStripMenuItem("About", Resources.AboutIcon, onAboutClicked),
                new ToolStripMenuItem("Exit", null, onExitClicked),
            };

            if (Settings.Default.WindowsListAtEnd)
            {
                ContextMenu.Items.AddRange(generalItems.ToArray());
                ContextMenu.Items.Add(new ToolStripSeparator());
                ContextMenu.Items.AddRange(windowsItems.ToArray());
            }
            else
            {
                ContextMenu.Items.AddRange(windowsItems.ToArray());
                ContextMenu.Items.Add(new ToolStripSeparator());
                ContextMenu.Items.AddRange(generalItems.ToArray());
            }

            e.Cancel = false;
        }

        private void onSelectWindowClicked(object sender, EventArgs e) => selectWindowFromScreen();

        private void onUnpinAllClicked(object sender, EventArgs e)
        {
            foreach (var kv in WinApi.GetWindowHandles())
            {
                WinApi.fWindowTopmost(kv.Key, false);
            }
        }

        private void onOptionsClicked(object sender, EventArgs e)
        {
            var optionsForm = new OptionsForm(this);
            optionsForm.ShowDialog();
        }

        private void onAboutClicked(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm(Resources.PinWinIconBlack.ToBitmap());
            aboutForm.AccentColor = Color.Black;
            aboutForm.StartPosition = FormStartPosition.CenterScreen;
            aboutForm.ShowDialog();
        }

        private void onExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Thực thi khi thoát app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            foreach (var property in this.GetType().GetProperties())
            {
                if (typeof(GlobalHotKey).Name == property.PropertyType.Name)
                {
                    GlobalHotKey key = (GlobalHotKey)property.GetValue(this);
                    // Save hot key
                    if (key != null)
                        Settings.Default.KeySelectWindow = (Keys)key?.KeyCombination;
                    else 
                        Settings.Default.KeySelectWindow = Keys.None;

                    key?.Dispose();
                }
            }

            Settings.Default.Save();
        }
    }
}
