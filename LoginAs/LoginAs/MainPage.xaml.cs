namespace LoginAs
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int count1 = 0;
        int count2 = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnStudentClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                StudentBtn.Text = $"Clicked {count} time";
            else
                StudentBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(StudentBtn.Text);
        }
        private void OnClubManagerClicked(object sender, EventArgs e)
        {
            count1++;

            if (count1 == 1)
                ClubManagerBtn.Text = $"Clicked {count1} time";
            else
                ClubManagerBtn.Text = $"Clicked {count1} times";

            SemanticScreenReader.Announce(StudentBtn.Text);
        }
        private void OnSksAdminClicked(object sender, EventArgs e)
        {
            count2++;

            if (count == 1)
                SksAdminBtn.Text = $"Clicked {count2} time";
            else
                SksAdminBtn.Text = $"Clicked {count2} times";

            SemanticScreenReader.Announce(StudentBtn.Text);
        }


    }

}
