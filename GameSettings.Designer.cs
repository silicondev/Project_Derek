﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed partial class GameSettings : global::System.Configuration.ApplicationSettingsBase {
    
    private static GameSettings defaultInstance = ((GameSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GameSettings())));
    
    public static GameSettings Default {
        get {
            return defaultInstance;
        }
    }
    
    [global::System.Configuration.ApplicationScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("16")]
    public int TileWidth {
        get {
            return ((int)(this["TileWidth"]));
        }
    }
    
    [global::System.Configuration.ApplicationScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("64")]
    public int TileHeight {
        get {
            return ((int)(this["TileHeight"]));
        }
    }
    
    [global::System.Configuration.ApplicationScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("16")]
    public int TileLength {
        get {
            return ((int)(this["TileLength"]));
        }
    }
}
