﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPrekt_DUC.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AddressList {
            get {
                return ((string)(this["AddressList"]));
            }
            set {
                this["AddressList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Setting_refreshRate {
            get {
                return ((int)(this["Setting_refreshRate"]));
            }
            set {
                this["Setting_refreshRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Setting_useProxy {
            get {
                return ((bool)(this["Setting_useProxy"]));
            }
            set {
                this["Setting_useProxy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://monip.org | IP\\s\\:\\s([\\d\\.]+)\r\nhttp://icanhazip.com | ([\\d\\.]+)\r\nhttp://ap" +
            "i.ipify.org | ([\\d\\.]+)\r\nhttp://curlmyip.com | ([\\d\\.]+)")]
        public string Setting_ipServiceList {
            get {
                return ((string)(this["Setting_ipServiceList"]));
            }
            set {
                this["Setting_ipServiceList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Setting_notifyUpdateSuccess {
            get {
                return ((bool)(this["Setting_notifyUpdateSuccess"]));
            }
            set {
                this["Setting_notifyUpdateSuccess"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Setting_notifyUpdateFail {
            get {
                return ((bool)(this["Setting_notifyUpdateFail"]));
            }
            set {
                this["Setting_notifyUpdateFail"] = value;
            }
        }
    }
}
