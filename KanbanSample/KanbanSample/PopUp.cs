using Syncfusion.XForms.ComboBox;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KanbanSample
{
    public class PopUp : ContentPage
    {
        public Editor editor;

        public SfComboBox comboBox;
        public PopUp()
        {
            this.BackgroundColor = Color.Transparent;
            this.WidthRequest = 200;
            this.HeightRequest = 100;

            var layout = new StackLayout();
            layout.Padding = new Thickness(50, 100);
            layout.BackgroundColor = Color.Silver;
            layout.Orientation = StackOrientation.Vertical;
            layout.HorizontalOptions = LayoutOptions.Center;
            layout.VerticalOptions = LayoutOptions.Center;

            var label = new Label();
            label.Text = "Enter Description:";
            label.FontSize = 14;
            label.TextColor = Color.Black;
            label.VerticalOptions = LayoutOptions.Center;

            editor = new Editor();
            editor.TextColor = Color.Black;
            editor.VerticalOptions = LayoutOptions.Center;

            var label2 = new Label();
            label2.Text = "select the Category:";
            label2.FontSize = 14;
            label2.TextColor = Color.Black;
            label2.VerticalOptions = LayoutOptions.Center;
            layout.Children.Add(label2);

            List<String> countryNames = new List<String>();
            countryNames.Add("Open");
            countryNames.Add("In Progress");
            countryNames.Add("Code Review");
            countryNames.Add("Done");

            comboBox = new SfComboBox();
            comboBox.HeightRequest = 40;
            comboBox.BackgroundColor = Color.AliceBlue;
            comboBox.ComboBoxSource = countryNames;
            layout.Children.Add(comboBox);

            var button = new Button();
            button.Text = "OK";
            button.BackgroundColor = Color.Blue;
            button.VerticalOptions = LayoutOptions.Center;
            button.Clicked += Button_Clicked;

            layout.Children.Add(label);
            layout.Children.Add(editor);
            layout.Children.Add(button);

            Content = layout;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
             Navigation.PopModalAsync();
        }
    }
}
