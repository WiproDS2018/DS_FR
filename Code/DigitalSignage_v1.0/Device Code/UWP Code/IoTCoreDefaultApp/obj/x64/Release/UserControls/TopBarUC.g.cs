﻿#pragma checksum "D:\Windows10493\IoTCoreDefaultApp\CS\IoTCoreDefaultApp\UserControls\TopBarUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "979C759D9035D4AF0304CD4997E8E9D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTCoreDefaultApp
{
    partial class TopBarUC : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.DeviceInfo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\UserControls\TopBarUC.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeviceInfo).Click += this.DeviceInfo_Clicked;
                    #line default
                }
                break;
            case 2:
                {
                    this.WebBrowser = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\UserControls\TopBarUC.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WebBrowser).Click += this.WebBrowserButton_Clicked;
                    #line default
                }
                break;
            case 3:
                {
                    this.CurrentTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.SettingsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 74 "..\..\..\UserControls\TopBarUC.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SettingsButton).Click += this.SettingsButton_Clicked;
                    #line default
                }
                break;
            case 5:
                {
                    this.ShutdownButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\UserControls\TopBarUC.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShutdownButton).Click += this.ShutdownButton_Clicked;
                    #line default
                }
                break;
            case 6:
                {
                    this.ShutdownDropdown = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                    #line 78 "..\..\..\UserControls\TopBarUC.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.Popup)this.ShutdownDropdown).Opened += this.ShutdownDropdown_Opened;
                    #line default
                }
                break;
            case 7:
                {
                    this.ShutdownListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 79 "..\..\..\UserControls\TopBarUC.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShutdownListView).ItemClick += this.ShutdownListView_ItemClick;
                    #line default
                }
                break;
            case 8:
                {
                    this.RestartOption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.ShutdownOption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
