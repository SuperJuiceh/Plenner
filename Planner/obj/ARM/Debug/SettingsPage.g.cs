﻿#pragma checksum "C:\Users\Bilel\source\repos\Plenner\Plenner\Planner\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E5BDD3C6C591B2CE0F3A12A77E62683"
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
    partial class SettingsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Nullable<global::System.Boolean>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Nullable<global::System.Boolean>), targetNullValue);
                }
                obj.IsChecked = value;
            }
            public static void Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(global::Windows.UI.Xaml.Media.ImageBrush obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.ImageSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class SettingsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingsPage_Bindings
        {
            private global::Planner.SettingsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.CheckBox obj10;
            private global::Windows.UI.Xaml.Controls.CheckBox obj11;
            private global::Windows.UI.Xaml.Media.ImageBrush obj22;

            private SettingsPage_obj1_BindingsTracking bindingsTracking;

            public SettingsPage_obj1_Bindings()
            {
                this.bindingsTracking = new SettingsPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // SettingsPage.xaml line 28
                        this.obj10 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        (this.obj10).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.Settings.Settings.SoundEnabled = (global::System.Boolean)this.obj10.IsChecked;
                            }
                        });
                        break;
                    case 11: // SettingsPage.xaml line 29
                        this.obj11 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        (this.obj11).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.Settings.Settings.EnableNotifications = (global::System.Boolean)this.obj11.IsChecked;
                            }
                        });
                        break;
                    case 22: // SettingsPage.xaml line 79
                        this.obj22 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    default:
                        break;
                }
            }

            // ISettingsPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Planner.SettingsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Planner.SettingsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Settings(obj.Settings, phase);
                    }
                }
            }
            private void Update_Settings(global::DataLab.Storage.SettingsStorage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Settings_Settings(obj.Settings, phase);
                    }
                }
            }
            private void Update_Settings_Settings(global::DataLab.Storage.PlannerSettings obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Settings_Settings(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Settings_Settings_SoundEnabled(obj.SoundEnabled, phase);
                        this.Update_Settings_Settings_EnableNotifications(obj.EnableNotifications, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Settings_Settings_NotificationIconString(obj.NotificationIconString, phase);
                    }
                }
            }
            private void Update_Settings_Settings_SoundEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SettingsPage.xaml line 28
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj10, obj, null);
                }
            }
            private void Update_Settings_Settings_EnableNotifications(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SettingsPage.xaml line 29
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj11, obj, null);
                }
            }
            private void Update_Settings_Settings_NotificationIconString(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SettingsPage.xaml line 79
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj22, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
            private class SettingsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SettingsPage_obj1_Bindings> weakRefToBindingObj; 

                public SettingsPage_obj1_BindingsTracking(SettingsPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SettingsPage_obj1_Bindings>(obj);
                }

                public SettingsPage_obj1_Bindings TryGetBindingObject()
                {
                    SettingsPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_Settings_Settings(null);
                }

                public void PropertyChanged_Settings_Settings(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SettingsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::DataLab.Storage.PlannerSettings obj = sender as global::DataLab.Storage.PlannerSettings;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Settings_Settings_SoundEnabled(obj.SoundEnabled, DATA_CHANGED);
                                bindings.Update_Settings_Settings_EnableNotifications(obj.EnableNotifications, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SoundEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Settings_Settings_SoundEnabled(obj.SoundEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnableNotifications":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Settings_Settings_EnableNotifications(obj.EnableNotifications, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::DataLab.Storage.PlannerSettings cache_Settings_Settings = null;
                public void UpdateChildListeners_Settings_Settings(global::DataLab.Storage.PlannerSettings obj)
                {
                    if (obj != cache_Settings_Settings)
                    {
                        if (cache_Settings_Settings != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Settings_Settings).PropertyChanged -= PropertyChanged_Settings_Settings;
                            cache_Settings_Settings = null;
                        }
                        if (obj != null)
                        {
                            cache_Settings_Settings = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Settings_Settings;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SettingsPage.xaml line 19
                {
                    this.mainSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // SettingsPage.xaml line 26
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // SettingsPage.xaml line 27
                {
                    this.settingsPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 5: // SettingsPage.xaml line 90
                {
                    this.save_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.save_button).Click += this.save_button_Click;
                }
                break;
            case 6: // SettingsPage.xaml line 95
                {
                    this.popup = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 7: // SettingsPage.xaml line 97
                {
                    this.popupTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // SettingsPage.xaml line 98
                {
                    this.popupMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // SettingsPage.xaml line 99
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Button_Click_1;
                }
                break;
            case 10: // SettingsPage.xaml line 28
                {
                    this.soundEnabledCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.soundEnabledCheckBox).Checked += this.soundEnabledCheckBox_Checked;
                }
                break;
            case 11: // SettingsPage.xaml line 29
                {
                    this.notificationsEnabledCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 12: // SettingsPage.xaml line 30
                {
                    this.planningItemExperationPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 13: // SettingsPage.xaml line 83
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                }
                break;
            case 14: // SettingsPage.xaml line 86
                {
                    this.selectedFont = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.selectedFont).SizeChanged += this.selectedFont_SizeChanged;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.selectedFont).SelectionChanged += this.selectedFont_SelectionChanged;
                }
                break;
            case 15: // SettingsPage.xaml line 87
                {
                    this.selectedFontSize = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.selectedFontSize).SelectionChanged += this.selectedFontSize_SelectionChanged;
                }
                break;
            case 16: // SettingsPage.xaml line 50
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // SettingsPage.xaml line 51
                {
                    this.currentImageButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 18: // SettingsPage.xaml line 55
                {
                    global::Windows.UI.Xaml.Controls.Button element18 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element18).Click += this.Button_Click_2;
                }
                break;
            case 19: // SettingsPage.xaml line 60
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.Button_Click_2;
                }
                break;
            case 20: // SettingsPage.xaml line 65
                {
                    global::Windows.UI.Xaml.Controls.Button element20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element20).Click += this.Button_Click_2;
                }
                break;
            case 21: // SettingsPage.xaml line 70
                {
                    global::Windows.UI.Xaml.Controls.Button element21 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element21).Click += this.Button_Click_2;
                }
                break;
            case 23: // SettingsPage.xaml line 31
                {
                    this.planningItemExperationCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.planningItemExperationCheckBox).Checked += this.checkBox2_Checked;
                }
                break;
            case 24: // SettingsPage.xaml line 39
                {
                    this.DaysComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.DaysComboBox).Loaded += this.DaysComboBox_Loaded;
                }
                break;
            case 25: // SettingsPage.xaml line 44
                {
                    this.HoursComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.HoursComboBox).Loaded += this.HoursComboBox_Loaded;
                }
                break;
            case 26: // SettingsPage.xaml line 45
                {
                    this.MinutesComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.MinutesComboBox).Loaded += this.MinutesComboBox_Loaded;
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
            switch(connectionId)
            {
            case 1: // SettingsPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SettingsPage_obj1_Bindings bindings = new SettingsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

