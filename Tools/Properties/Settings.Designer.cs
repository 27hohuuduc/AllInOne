﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+Alt+V")]
        public global::System.Windows.Forms.Keys KeySelectWindow {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeySelectWindow"]));
            }
            set {
                this["KeySelectWindow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlwaysCheckForUpdates {
            get {
                return ((bool)(this["AlwaysCheckForUpdates"]));
            }
            set {
                this["AlwaysCheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int TitleLengthLimit {
            get {
                return ((int)(this["TitleLengthLimit"]));
            }
            set {
                this["TitleLengthLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WindowsListAtEnd {
            get {
                return ((bool)(this["WindowsListAtEnd"]));
            }
            set {
                this["WindowsListAtEnd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+4")]
        public global::System.Windows.Forms.Keys KeyGetShell {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeyGetShell"]));
            }
            set {
                this["KeyGetShell"] = value;
            }
        }
    }
}
