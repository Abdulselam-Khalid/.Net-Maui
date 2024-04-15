using System.Timers;
namespace SksClubPage;

public partial class MainPage : ContentPage
{
    private bool isLogo1Visible = true;
    private bool isTimerRunning = false;
    private System.Timers.Timer timer;
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnButtonClicked1(object sender, EventArgs e)
    {

    }
    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Warning", "Hi Anastassia!\r\nDeleting this club will erase all events, pictures, and group history This action is irreversible \r\nAre you sure you want to delete it?", "Delete", "Cancel");

        
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        StartTimer();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        StopTimer();
    }

    private void StartTimer()
    {
        if (!isTimerRunning)
        {
            isTimerRunning = true;
            timer = new System.Timers.Timer(3000); // Specify System.Timers namespace
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
            timer.Start();
        }
    }

    private void StopTimer()
    {
        if (isTimerRunning)
        {
            isTimerRunning = false;
            timer.Stop();
            timer.Dispose();
        }
    }

    private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e) // Specify System.Timers namespace
    {
        Device.BeginInvokeOnMainThread(() =>
        {
            if (isLogo1Visible)
            {
                logo1.IsVisible = false;
                logo2.IsVisible = true;
            }
            else
            {
                logo1.IsVisible = true;
                logo2.IsVisible = false;
            }

            isLogo1Visible = !isLogo1Visible;
        });
    }
}