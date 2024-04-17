using static NotificationSks.MainPage;

namespace NotificationSks
{
    public class MainPageViewModel
    {
        public EventDetails Event1 { get; set; }
        public EventDetails Event2 { get; set; }

        public MainPageViewModel()
        {
            // Initialize with sample data
            Event1 = new EventDetails
            {
                RequestType="New Events Request",
                ClubName="Music",
                ImageSource = "second.png",
                EventName = "Music Night",
                EventDate = "April 20, 2024",
                EventLocation = "Downtown Club"
            };

            Event2 = new EventDetails
            {
                RequestType = "Requesting Edits",
                ClubName="Art",
                ImageSource = "second.png",
                EventName = "Art Exhibition",
                EventDate = "April 25, 2024",
                EventLocation = "City Gallery"
            };
        }
    }
    public class EventDetails
    {
        public string RequestType {  get; set; }
        public string ClubName {  get; set; }
        public string ImageSource { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventLocation { get; set; }
    }
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        


    }

}
