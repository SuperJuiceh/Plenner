using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Planner.Data.Converters;
using Planner;
using Planner.Data;
using Planner.Data.Styling;
using DataLab.Data.Planning;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddDiaryPage : Page
    {
        
        public PlanningItemStorage Planning { get; set; }

        public SettingsStorage Settings { get; set; }
        

        public AddDiaryPage()
        {

            Planning = GeneralApplicationData.Planning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);
            
            this.InitializeComponent();
        }

        private void mainGrid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReflectionsPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }

        private void generateDiaryButton_Click(object sender, RoutedEventArgs e)
        {
            List<Type> types = new List<Type>();
            
            typesListBox.SelectedItems.Cast<ListBoxItem>().ToList().ForEach(selecteditem =>
            {
                string text = selecteditem.Content as string;

                if (text == "Activities"){
                    types.Add(typeof(Activity));
                }
                else if (text == "Reflections")
                {
                    types.Add(typeof(Reflection));
                }
                else if (text == "ToDoItems")
                {
                    types.Add(typeof(ToDoItem));
                }
            });
            
            Diary diary = Diary.CreateDiary(Planning.plan, 
                                            "haha",  
                                            ClassConverters.DateAndTimeToDateTime(startDatePicker.Date, startTimePicker.Time),
                                            ClassConverters.DateAndTimeToDateTime(startDatePicker.Date, startTimePicker.Time),
                                            types.ToArray());

            Planning.addDiary(diary);

            this.Frame.Navigate(typeof(ShowDiaryPage), diary);


        }
    }
}
