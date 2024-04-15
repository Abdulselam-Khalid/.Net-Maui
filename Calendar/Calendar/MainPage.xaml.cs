using Plugin.Maui.Calendar.Models;
namespace Calendar
{
    public partial class MainPage : ContentPage
    {
        public EventCollection Events { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Events = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event1", Description = "This is Cool event1's description!", ImagePath = "second.png" },
                    new EventModel { Name = "Cool event2", Description = "This is Cool event2's description!", ImagePath = "second.png" }
                },
                [DateTime.Now.AddDays(5)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event3", Description = "This is Cool event3's description!", ImagePath = "second.png" },
                    new EventModel { Name = "Cool event4", Description = "This is Cool event4's description!", ImagePath = "second.png" }
                },
                [DateTime.Now.AddDays(-3)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event5", Description = "This is Cool event5's description!", ImagePath = "second.png" }
                },
                [new DateTime(2024, 3, 28)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event6", Description = "This is Cool event6's description!", ImagePath = "second.png" }
                }
            };
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

    internal class EventModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
