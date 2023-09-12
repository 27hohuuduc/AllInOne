using Bluegrams.Windows.Tools;
using System;
using System.Windows.Forms;

namespace Tools
{
    public static class RegisterHotKey
    {
        /// <summary>
        /// Register hot key
        /// </summary>
        /// <param name="hotKey"></param>
        /// <param name="keyCombination"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static GlobalHotKey SetHotKey(GlobalHotKey hotKey, KeyCombination keyCombination, Action<GlobalHotKey> action)
        {
            hotKey?.Dispose();
            hotKey = null;
            if (keyCombination == KeyCombination.None || action == null) return hotKey;
            hotKey = new GlobalHotKey(keyCombination, action);
            if (!hotKey.Register())
            {
                MessageBox.Show("Failed to register global shortcut.\nThis may happen if the defined shortcut is already in use.", "PinWin - Error");
                return null;
            }
            return hotKey;
        }
    }
}
