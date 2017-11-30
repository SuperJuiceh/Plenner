﻿#pragma checksum "C:\Users\Bilel\source\repos\Plenner\Plenner\Planner\Modules\TimeFlowPanel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D2D2942FF18F47524D763628DF99CC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planner.Modules
{
    partial class TimeFlowPanel : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_FrameworkElement_Width(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Width = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_DataContext(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.DataContext = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Margin(global::Windows.UI.Xaml.FrameworkElement obj, global::Windows.UI.Xaml.Thickness value)
            {
                obj.Margin = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class TimeFlowPanel_obj14_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITimeFlowPanel_Bindings
        {
            private global::DataLab.Data.Planning.PlanningItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;

            public TimeFlowPanel_obj14_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 14: // Modules\TimeFlowPanel.xaml line 86
                        this.obj14 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.RelativePanel)target);
                        break;
                    case 15: // Modules\TimeFlowPanel.xaml line 87
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.RelativePanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DataLab.Data.Planning.PlanningItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // ITimeFlowPanel_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DataLab.Data.Planning.PlanningItem)newDataRoot;
                    return true;
                }
                return false;
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DataLab.Data.Planning.PlanningItem obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 86
                    if ((this.obj14.Target as global::Windows.UI.Xaml.Controls.RelativePanel) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Margin((this.obj14.Target as global::Windows.UI.Xaml.Controls.RelativePanel), (global::Windows.UI.Xaml.Thickness)this.LookupConverter("timeToMarginConv").Convert(obj, typeof(global::Windows.UI.Xaml.Thickness), null, null));
                    }
                    // Modules\TimeFlowPanel.xaml line 86
                    if ((this.obj14.Target as global::Windows.UI.Xaml.Controls.RelativePanel) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width((this.obj14.Target as global::Windows.UI.Xaml.Controls.RelativePanel), (global::System.Double)this.LookupConverter("timeToWidthConv").Convert(obj, typeof(global::System.Double), null, null));
                    }
                    // Modules\TimeFlowPanel.xaml line 87
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj15, (global::System.Double)this.LookupConverter("timeToWidthConv").Convert(obj, typeof(global::System.Double), null, null));
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class TimeFlowPanel_obj17_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITimeFlowPanel_Bindings
        {
            private global::DataLab.Data.Planning.PlanningItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;

            public TimeFlowPanel_obj17_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 17: // Modules\TimeFlowPanel.xaml line 74
                        this.obj17 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.RelativePanel)target);
                        break;
                    case 18: // Modules\TimeFlowPanel.xaml line 75
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.RelativePanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DataLab.Data.Planning.PlanningItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // ITimeFlowPanel_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DataLab.Data.Planning.PlanningItem)newDataRoot;
                    return true;
                }
                return false;
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DataLab.Data.Planning.PlanningItem obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 74
                    if ((this.obj17.Target as global::Windows.UI.Xaml.Controls.RelativePanel) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Margin((this.obj17.Target as global::Windows.UI.Xaml.Controls.RelativePanel), (global::Windows.UI.Xaml.Thickness)this.LookupConverter("timeToMarginConv").Convert(obj, typeof(global::Windows.UI.Xaml.Thickness), null, null));
                    }
                    // Modules\TimeFlowPanel.xaml line 74
                    if ((this.obj17.Target as global::Windows.UI.Xaml.Controls.RelativePanel) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width((this.obj17.Target as global::Windows.UI.Xaml.Controls.RelativePanel), (global::System.Double)this.LookupConverter("timeToWidthConv").Convert(obj, typeof(global::System.Double), null, null));
                    }
                    // Modules\TimeFlowPanel.xaml line 75
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj18, (global::System.Double)this.LookupConverter("timeToWidthConv").Convert(obj, typeof(global::System.Double), null, null));
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class TimeFlowPanel_obj20_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITimeFlowPanel_Bindings
        {
            private global::DataLab.Data.Planning.PlanningItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.RelativePanel obj21;
            private global::Windows.UI.Xaml.Controls.TextBlock obj22;

            public TimeFlowPanel_obj20_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 21: // Modules\TimeFlowPanel.xaml line 62
                        this.obj21 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 22: // Modules\TimeFlowPanel.xaml line 63
                        this.obj22 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.RelativePanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DataLab.Data.Planning.PlanningItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // ITimeFlowPanel_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DataLab.Data.Planning.PlanningItem)newDataRoot;
                    return true;
                }
                return false;
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DataLab.Data.Planning.PlanningItem obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 62
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Margin(this.obj21, (global::Windows.UI.Xaml.Thickness)this.LookupConverter("timeToMarginConv").Convert(obj, typeof(global::Windows.UI.Xaml.Thickness), null, null));
                    // Modules\TimeFlowPanel.xaml line 62
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj21, (global::System.Double)this.LookupConverter("timeToWidthConv").Convert(obj, typeof(global::System.Double), null, null));
                    // Modules\TimeFlowPanel.xaml line 63
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj22, (global::System.Double)this.LookupConverter("timeToWidthConv").Convert(obj, typeof(global::System.Double), null, null));
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class TimeFlowPanel_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITimeFlowPanel_Bindings
        {
            private global::Planner.Modules.TimeFlowPanel dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.RelativePanel obj5;
            private global::Windows.UI.Xaml.Controls.Grid obj6;
            private global::Windows.UI.Xaml.Controls.RelativePanel obj8;
            private global::Windows.UI.Xaml.Controls.RelativePanel obj9;
            private global::Windows.UI.Xaml.Controls.RelativePanel obj10;
            private global::Windows.UI.Xaml.Controls.RelativePanel obj11;
            private global::Windows.UI.Xaml.Controls.RelativePanel obj12;
            private global::Windows.UI.Xaml.Controls.ItemsControl obj13;
            private global::Windows.UI.Xaml.Controls.ItemsControl obj16;
            private global::Windows.UI.Xaml.Controls.ItemsControl obj19;
            private global::Windows.UI.Xaml.Controls.CheckBox obj24;
            private global::Windows.UI.Xaml.Controls.CheckBox obj25;
            private global::Windows.UI.Xaml.Controls.CheckBox obj26;

            public TimeFlowPanel_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Modules\TimeFlowPanel.xaml line 18
                        this.obj5 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 6: // Modules\TimeFlowPanel.xaml line 31
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 8: // Modules\TimeFlowPanel.xaml line 55
                        this.obj8 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 9: // Modules\TimeFlowPanel.xaml line 56
                        this.obj9 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 10: // Modules\TimeFlowPanel.xaml line 57
                        this.obj10 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 11: // Modules\TimeFlowPanel.xaml line 70
                        this.obj11 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 12: // Modules\TimeFlowPanel.xaml line 82
                        this.obj12 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        break;
                    case 13: // Modules\TimeFlowPanel.xaml line 83
                        this.obj13 = (global::Windows.UI.Xaml.Controls.ItemsControl)target;
                        break;
                    case 16: // Modules\TimeFlowPanel.xaml line 71
                        this.obj16 = (global::Windows.UI.Xaml.Controls.ItemsControl)target;
                        break;
                    case 19: // Modules\TimeFlowPanel.xaml line 58
                        this.obj19 = (global::Windows.UI.Xaml.Controls.ItemsControl)target;
                        break;
                    case 24: // Modules\TimeFlowPanel.xaml line 40
                        this.obj24 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        break;
                    case 25: // Modules\TimeFlowPanel.xaml line 41
                        this.obj25 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        break;
                    case 26: // Modules\TimeFlowPanel.xaml line 42
                        this.obj26 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        break;
                    default:
                        break;
                }
            }

            // ITimeFlowPanel_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Planner.Modules.TimeFlowPanel)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Planner.Modules.TimeFlowPanel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MainPanelWidth(obj.MainPanelWidth, phase);
                        this.Update_MainTimeFlow(obj.MainTimeFlow, phase);
                    }
                }
            }
            private void Update_MainPanelWidth(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 18
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj5, obj);
                    // Modules\TimeFlowPanel.xaml line 31
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj6, obj);
                    // Modules\TimeFlowPanel.xaml line 55
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj8, obj);
                    // Modules\TimeFlowPanel.xaml line 56
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj9, obj);
                    // Modules\TimeFlowPanel.xaml line 57
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj10, obj);
                    // Modules\TimeFlowPanel.xaml line 70
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj11, obj);
                    // Modules\TimeFlowPanel.xaml line 82
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj12, obj);
                    // Modules\TimeFlowPanel.xaml line 83
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj13, obj);
                    // Modules\TimeFlowPanel.xaml line 71
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj16, obj);
                    // Modules\TimeFlowPanel.xaml line 58
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj19, obj);
                }
            }
            private void Update_MainTimeFlow(global::Planner.Data.Tools.TimeFlow.TimeFlow obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MainTimeFlow_TimeLineToDoItems(obj.TimeLineToDoItems, phase);
                        this.Update_MainTimeFlow_TimeLineReflections(obj.TimeLineReflections, phase);
                        this.Update_MainTimeFlow_TimeLineActivities(obj.TimeLineActivities, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 40
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_DataContext(this.obj24, obj, null);
                    // Modules\TimeFlowPanel.xaml line 41
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_DataContext(this.obj25, obj, null);
                    // Modules\TimeFlowPanel.xaml line 42
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_DataContext(this.obj26, obj, null);
                }
            }
            private void Update_MainTimeFlow_TimeLineToDoItems(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 83
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj13, obj, null);
                }
            }
            private void Update_MainTimeFlow_TimeLineReflections(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 71
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj16, obj, null);
                }
            }
            private void Update_MainTimeFlow_TimeLineActivities(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Modules\TimeFlowPanel.xaml line 58
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj19, obj, null);
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
            case 2: // Modules\TimeFlowPanel.xaml line 14
                {
                    this.timeToWidthConv = (global::Planner.Data.Converters.TimeToElementWidthConverter)(target);
                }
                break;
            case 3: // Modules\TimeFlowPanel.xaml line 15
                {
                    this.itemToPanelInfo = (global::Planner.Data.Converters.PlanningItemToInfoPanelConverter)(target);
                }
                break;
            case 4: // Modules\TimeFlowPanel.xaml line 16
                {
                    this.timeToMarginConv = (global::Planner.Data.Converters.ItemTimeToMarginConverter)(target);
                }
                break;
            case 5: // Modules\TimeFlowPanel.xaml line 18
                {
                    this.MainPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 6: // Modules\TimeFlowPanel.xaml line 31
                {
                    this.numbersTableHeaderPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // Modules\TimeFlowPanel.xaml line 32
                {
                    this.configFlyoutOpenButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.configFlyoutOpenButton).Click += this.configFlyoutOpenButton_Click;
                }
                break;
            case 19: // Modules\TimeFlowPanel.xaml line 58
                {
                    this.timeLineActivitiesItemsControl = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 23: // Modules\TimeFlowPanel.xaml line 46
                {
                    this.timeFlowDatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.DatePicker)this.timeFlowDatePicker).DateChanged += this.timeFlowDatePicker_DateChanged;
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
            case 1: // Modules\TimeFlowPanel.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    TimeFlowPanel_obj1_Bindings bindings = new TimeFlowPanel_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 14: // Modules\TimeFlowPanel.xaml line 86
                {                    
                    global::Windows.UI.Xaml.Controls.RelativePanel element14 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                    TimeFlowPanel_obj14_Bindings bindings = new TimeFlowPanel_obj14_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element14.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element14.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element14, bindings);
                }
                break;
            case 17: // Modules\TimeFlowPanel.xaml line 74
                {                    
                    global::Windows.UI.Xaml.Controls.RelativePanel element17 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                    TimeFlowPanel_obj17_Bindings bindings = new TimeFlowPanel_obj17_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element17.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element17.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element17, bindings);
                }
                break;
            case 20: // Modules\TimeFlowPanel.xaml line 61
                {                    
                    global::Windows.UI.Xaml.Controls.RelativePanel element20 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                    TimeFlowPanel_obj20_Bindings bindings = new TimeFlowPanel_obj20_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element20.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element20.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element20, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

