﻿#pragma checksum "C:\Users\Bilel\source\repos\Plenner\Planner\SendMailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "511F399BBB3F078B71D334F6B2AB827B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planner
{
    partial class SendMailPage : 
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
            case 1: // SendMailPage.xaml line 10
                {
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element1).DoubleTapped += this.Grid_DoubleTapped;
                }
                break;
            case 2: // SendMailPage.xaml line 14
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // SendMailPage.xaml line 15
                {
                    this.recepients_textbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // SendMailPage.xaml line 16
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // SendMailPage.xaml line 17
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // SendMailPage.xaml line 22
                {
                    this.send_mail_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.send_mail_button).Click += this.send_mail_button_Click;
                }
                break;
            case 7: // SendMailPage.xaml line 27
                {
                    this.textBox2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // SendMailPage.xaml line 28
                {
                    this.message_text_box = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // SendMailPage.xaml line 29
                {
                    this.status_text_block = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

