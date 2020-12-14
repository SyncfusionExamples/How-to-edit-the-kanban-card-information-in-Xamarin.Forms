using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace KanbanSample
{
    public class CustomViewModel 
    {
        public ObservableCollection<CustomModel> Cards { get; set; }


        public CustomViewModel()
        {
            Cards = new ObservableCollection<CustomModel>();

         

            Cards.Add(new CustomModel()
            {
                ID = 1985,
                Title = "iOS - 1002",
                Category = "Open",
                ImageURL = "People_Circle1.png",
                Description = "Analyze the customer requirements",
                ColorKey = "Red",
            });

            Cards.Add(new CustomModel()
            {
                ID = 6347,
                Title = "Xamarin - 4576",
                Category = "Open",
                ImageURL = "People_Circle2.png",
                Description = "Show retrieved data in grid control",
                ColorKey = "Green",
            });

            Cards.Add(new CustomModel()
            {
                ID = 1398,
                Title = "UWP - 13",
                Category = "In Progress",
                ImageURL = "People_Circle3.png",
                Description = "Add responsive support to application",
                ColorKey = "Aqua",
            });

            Cards.Add(new CustomModel()
            {
                ID = 2543,
                Title = "Xamarin_iOS - 2543",
                Category = "Code Review",
                ImageURL = "People_Circle4.png",
                Description = "Provide swimlane support kanban",
                ColorKey = "Blue",
            });

            Cards.Add(new CustomModel()
            {
                ID = 1975,
                Title = "iOS - 1975",
                Category = "Done",
                ImageURL = "Person.png",
                Description = "Fix the issues reported by the customer",
                ColorKey = "Purple",
            });
        }

    }

    public class CustomModel : KanbanModel
    {
        
    }
  
}
