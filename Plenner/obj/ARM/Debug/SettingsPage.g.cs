﻿#pragma checksum "C:\Users\Bilel\Documents\Visual Studio 2017\Projects\Plenner\Plenner\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9027C67B04B8938276D261736146B410"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plenner
{
    partial class SettingsPage : 
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
                    global::Windows.UI.Xaml.Controls.RelativePanel element1 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 21 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element1).ManipulationStarted += this.RelativePanel_ManipulationStarted;
                    #line 21 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element1).ManipulationCompleted += this.RelativePanel_ManipulationCompleted;
                    #line default
                }
                break;
            case 2:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.settingsPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 4:
                {
                    this.save_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.save_button).Click += this.save_button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.popup = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 6:
                {
                    this.popupTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.popupMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 82 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Button_Click_1;
                    #line default
                }
                break;
            case 9:
                {
                    this.soundEnabledCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 32 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.soundEnabledCheckBox).Checked += this.soundEnabledCheckBox_Checked;
                    #line default
                }
                break;
            case 10:
                {
                    this.notificationsEnabledCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 11:
                {
                    this.planningItemExperationPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 12:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 70 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 15:
                {
                    this.planningItemExperationCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 35 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.planningItemExperationCheckBox).Checked += this.checkBox2_Checked;
                    #line default
                }
                break;
            case 16:
                {
                    this.DaysComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 44 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.DaysComboBox).Loaded += this.DaysComboBox_Loaded;
                    #line default
                }
                break;
            case 17:
                {
                    this.HoursComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 49 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.HoursComboBox).Loaded += this.HoursComboBox_Loaded;
                    #line default
                }
                break;
            case 18:
                {
                    this.MinutesComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 50 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.MinutesComboBox).Loaded += this.MinutesComboBox_Loaded;
                    #line default
                }
                break;
            case 19:
                {
                    this.SecondsComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 51 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.SecondsComboBox).Loaded += this.SecondsComboBox_Loaded;
                    #line default
                }
                break;
            case 20:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

