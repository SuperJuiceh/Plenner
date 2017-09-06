﻿#pragma checksum "C:\Users\Bilel\source\repos\Plenner\Planner\ToDoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42F81D6ECA5778052F7639353DD51DC9"
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
    partial class ToDoPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class ToDoPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IToDoPage_Bindings
        {
            private global::Planner.ToDoPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj4;
            private global::Windows.UI.Xaml.Controls.ListView obj5;

            public ToDoPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // ToDoPage.xaml line 27
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 5: // ToDoPage.xaml line 55
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IToDoPage_Bindings

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
                    this.dataRoot = (global::Planner.ToDoPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Planner.ToDoPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Planning(obj.Planning, phase);
                    }
                }
            }
            private void Update_Planning(global::DataLab.Storage.PlanningItemStorage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Planning_plan(obj.plan, phase);
                    }
                }
            }
            private void Update_Planning_plan(global::DataLab.Data.Planning.Plan obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Planning_plan_ToDoItems(obj.ToDoItems, phase);
                        this.Update_Planning_plan_tdiSets(obj.tdiSets, phase);
                    }
                }
            }
            private void Update_Planning_plan_ToDoItems(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ToDoPage.xaml line 27
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                }
            }
            private void Update_Planning_plan_tdiSets(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ToDoPage.xaml line 55
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
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
            case 2: // ToDoPage.xaml line 12
                {
                    this.mainSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // ToDoPage.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element3).DoubleTapped += this.Grid_DoubleTapped;
                }
                break;
            case 4: // ToDoPage.xaml line 27
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5: // ToDoPage.xaml line 55
                {
                    this.listViewtdiSets = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 6: // ToDoPage.xaml line 103
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // ToDoPage.xaml line 105
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // ToDoPage.xaml line 118
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2).Click += this.button2_Click;
                }
                break;
            case 9: // ToDoPage.xaml line 111
                {
                    this.listBoxItemChildren = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.listBoxItemChildren).SelectionChanged += this.ListBox_SelectionChanged;
                }
                break;
            case 10: // ToDoPage.xaml line 88
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element10 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element10).Checked += this.CheckBox_Checked;
                }
                break;
            case 11: // ToDoPage.xaml line 89
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.Button_Click_1;
                }
                break;
            case 12: // ToDoPage.xaml line 69
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.mailToDoItemSetButton_Click;
                }
                break;
            case 13: // ToDoPage.xaml line 74
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element13 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element13).Checked += this.CheckBox_Checked;
                }
                break;
            case 14: // ToDoPage.xaml line 75
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.tdiset_remove_button_Click;
                }
                break;
            case 15: // ToDoPage.xaml line 30
                {
                    this.toDoItemNameHeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.toDoItemNameHeaderTextBlock).Tapped += this.toDoItemNameHeaderTextBlock_Tapped;
                }
                break;
            case 16: // ToDoPage.xaml line 31
                {
                    this.toDoItemTimeHeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.toDoItemTimeHeaderTextBlock).Tapped += this.toDoItemTimeHeaderTextBlock_Tapped;
                }
                break;
            case 17: // ToDoPage.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.mailToDoItemButton_Click;
                }
                break;
            case 18: // ToDoPage.xaml line 45
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element18 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element18).Checked += this.CheckBox_Checked;
                }
                break;
            case 19: // ToDoPage.xaml line 46
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.Button_Click_1;
                }
                break;
            case 20: // ToDoPage.xaml line 132
                {
                    this.splitViewOpenCloseButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.splitViewOpenCloseButton).Click += this.splitViewOpenCloseButton_Click;
                }
                break;
            case 21: // ToDoPage.xaml line 138
                {
                    this.activitiesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.activitiesButton).Click += this.activitiesButton_Click;
                }
                break;
            case 22: // ToDoPage.xaml line 143
                {
                    this.reflectionsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.reflectionsButton).Click += this.reflectionsButton_Click;
                }
                break;
            case 23: // ToDoPage.xaml line 148
                {
                    this.settingsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.settingsButton).Click += this.settingsButton_Click;
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
            case 1: // ToDoPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ToDoPage_obj1_Bindings bindings = new ToDoPage_obj1_Bindings();
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

