using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Planner.Data.Styling
{
    public static class UserStyleFactory
    {

        private static PlannerSettings Settings;

        public static void addStyles(ResourceDictionary resources, PlannerSettings settings)
        {
            try
            {
                Settings = settings;

                resources.Add(typeof(Button), StijlButton);
                resources.Add(typeof(TextBlock), StijlTextBlock);
                resources.Add(typeof(TextBox), StijlTextBox);
                resources.Add(typeof(CheckBox), StijlCheckBox);
                resources.Add(typeof(ListView), StijlListView);
            } catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            
        }
        

        public static Style StijlTextBlock
        {
            get
            {
                Style style = new Style();

                new List<Setter>() {
                    new Setter() { Property = TextBlock.FontStyleProperty, Value = Settings.FontTypeUser },
                    new Setter() { Property = TextBlock.FontSizeProperty,  Value = Settings.FontSizeUser }
                }.ForEach(set =>
                {
                    style.Setters.Add(set);
                });

                style.TargetType = typeof(TextBlock);

                return style;
            }


        }

        public static Style StijlButton
        {
            get
            {
                Style style = new Style();

                new List<Setter>() {
                    new Setter() { Property = Button.FontStyleProperty, Value = Settings.FontTypeUser },
                    new Setter() { Property = Button.FontSizeProperty,  Value = Settings.FontSizeUser }
                }.ForEach(set =>
                {
                    style.Setters.Add(set);
                });

                style.TargetType = typeof(Button);

                return style;
            }





        }

        public static Style StijlTextBox
        {
            get
            {
                Style style = new Style();

                new List<Setter>() {
                    new Setter() { Property = TextBox.FontStyleProperty, Value = Settings.FontTypeUser },
                    new Setter() { Property = TextBox.FontSizeProperty,  Value = Settings.FontSizeUser }
                }.ForEach(set =>
                {
                    style.Setters.Add(set);
                });

                style.TargetType = typeof(TextBox);

                return style;
            }
            
        }

        public static Style StijlCheckBox
        {
            get
            {
                Style style = new Style();

                new List<Setter>() {
                    new Setter() { Property = CheckBox.FontStyleProperty, Value = Settings.FontTypeUser },
                    new Setter() { Property = CheckBox.FontSizeProperty,  Value = Settings.FontSizeUser }
                }.ForEach(set =>
                {
                    style.Setters.Add(set);
                });

                style.TargetType = typeof(CheckBox);

                return style;
            }
        }

        public static Style StijlListView
        {
            get
            {
                Style style = new Style();

                new List<Setter>() {
                    new Setter() { Property = ListView.FontStyleProperty, Value = Settings.FontTypeUser },
                    new Setter() { Property = ListView.FontSizeProperty,  Value = Settings.FontSizeUser }
                }.ForEach(set =>
                {
                    style.Setters.Add(set);
                });

                style.TargetType = typeof(ListView);

                return style;
            }
        }
    }
}
