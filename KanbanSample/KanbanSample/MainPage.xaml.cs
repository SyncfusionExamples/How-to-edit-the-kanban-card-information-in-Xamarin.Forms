using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KanbanSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            todoColumn.Categories = new List<object>() { "Open" };
            progressColumn.Categories = new List<object>() { "In Progress" };
            codeColumn.Categories = new List<object>() { "Code Review" };
            doneColumn.Categories = new List<object>() { "Done" };
        }

        private void Kanban_ItemTapped(object sender, KanbanTappedEventArgs e)
        {
            var data = viewModel;
            ShowPopup((data as CustomViewModel), (e.Data as CustomModel));
        }

        private void ShowPopup(CustomViewModel viewModeldata, CustomModel modelData)
        {
            var editPage = new PopUp();
            Navigation.PushModalAsync(editPage);
            editPage.comboBox.SelectionChanged += (textSender, eventArgs) =>
            {
                if ((viewModeldata as CustomViewModel).Cards.Contains(modelData as CustomModel))
                {
                    (modelData as CustomModel).Category = editPage.comboBox.SelectedItem;
                }
                kanban.ItemsSource = null;
                kanban.ItemsSource = viewModel.Cards;
            };
            editPage.editor.Completed += (textSender, eventArgs) =>
            {
                if ((viewModeldata as CustomViewModel).Cards.Contains(modelData as CustomModel))
                {;
                    
                    (modelData as CustomModel).Description = editPage.editor.Text;
                }
            };
        }
    }

    
}
