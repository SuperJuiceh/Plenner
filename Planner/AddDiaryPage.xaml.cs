using DataLab.Storage;
using DataLab.Data.Planning;
using Planner.Data.Converters;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddDiaryPage : Page
    {

        public PlanningItemStorage plan { get; set; }

        public AddDiaryPage()
        {
            this.InitializeComponent();
        }

        private void mainGrid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReflectionsPage), plan);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage tempPlan = e.Parameter as PlanningItemStorage;

            if (tempPlan != null)
            {

                plan = tempPlan;
            }   
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
            
            Diary diary = Diary.CreateDiary(plan.plan, 
                                            "haha",  
                                            ClassConverters.DateAndTimeToDateTime(startDatePicker.Date, startTimePicker.Time),
                                            ClassConverters.DateAndTimeToDateTime(startDatePicker.Date, startTimePicker.Time),
                                            types.ToArray());

            plan.addDiary(diary);

            this.Frame.Navigate(typeof(ShowDiaryPage), new Tuple<PlanningItemStorage, Diary>(plan, diary));


        }
    }
}
