﻿#pragma checksum "D:\Windows10493\IoTCoreDefaultApp\CS\IoTCoreDefaultApp\Views\WebBrowserPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8C556B5CCADDFAEAA2EE54689AB18693"
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
    partial class WebBrowserPage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 30 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.OnPageLoaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.HeaderRow = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.ViewGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.prStatus = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.ContentView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                    #line 92 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.ContentView).NavigationStarting += this.ContentView_NavigationStarting;
                    #line 92 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.ContentView).NavigationCompleted += this.ContentView_NavigationCompleted;
                    #line 92 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.ContentView).LongRunningScriptDetected += this.ContentView_LongRunningScriptDetected;
                    #line 92 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.ContentView).DOMContentLoaded += this.ContentView_DOMContentLoaded;
                    #line default
                }
                break;
            case 6:
                {
                    this.MessageStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.Message1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.Message2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.SettingsDirect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 99 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SettingsDirect).Click += this.OnSettings_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.ImageProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 11:
                {
                    this.WebBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WebBackButton).Click += this.BackButton_Clicked;
                    #line default
                }
                break;
            case 12:
                {
                    this.WebNextButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 69 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WebNextButton).Click += this.NextButton_Clicked;
                    #line default
                }
                break;
            case 13:
                {
                    this.WebRefreshButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WebRefreshButton).Click += this.WebGoButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.WebAddressText = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 76 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.WebAddressText).LostFocus += this.WebAddressText_LostFocus;
                    #line 76 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.WebAddressText).TextChanged += this.WebAddressText_TextChanged;
                    #line 76 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.WebAddressText).KeyUp += this.WebAddressText_KeyUp;
                    #line 76 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.WebAddressText).FocusEngaged += this.WebAddressText_FocusEngaged;
                    #line 76 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.WebAddressText).SuggestionChosen += this.WebAddressText_SuggestionChosen;
                    #line 76 "..\..\..\Views\WebBrowserPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.WebAddressText).QuerySubmitted += this.WebAddressText_QuerySubmitted;
                    #line default
                }
                break;
            case 15:
                {
                    this.TopBar = (global::IoTCoreDefaultApp.TopBarUC)(target);
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
