namespace Account.Maui
{
    public partial class MainPage : ContentPage
    {
        private string previousPhoneNumber;
        public MainPage()
        {
            InitializeComponent();
        }

        private void LogOutButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Clicked(object sender, EventArgs e)
        {
            phoneNumberLabel.IsEnabled = true;
            previousPhoneNumber = phoneNumberLabel.Text;
            phoneNumberLabel.Text = string.Empty;
            phoneNumberLabel.Placeholder = previousPhoneNumber;
            changeButton.Text = "Save";
            changeButton.Clicked -= ChangeButton_Clicked;
            changeButton.Clicked += SaveButton_Clicked;
        }



        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            phoneNumberLabel.Text = phoneNumberLabel.Text.Replace(" ", "");
            if (!string.IsNullOrWhiteSpace(phoneNumberLabel.Text) && phoneNumberLabel.Text.Length == 10)
            {
                phoneNumberLabel.Text = FormatPhoneNumber(phoneNumberLabel.Text);

                phoneNumberLabel.IsEnabled = false;
                phoneNumberLabel.TextColor = Colors.Black;
                changeButton.Text = "Change";
                changeButton.Clicked -= SaveButton_Clicked;
                changeButton.Clicked += ChangeButton_Clicked;
            }
            else
            {
                DisplayAlert("Error", "Please enter a valid 10-digit phone number.", "OK");
            }
        }


        private static string FormatPhoneNumber(string phoneNumber)
        {
            return string.Format("({0}) {1} {2}",
                phoneNumber.Substring(0, 3),
                phoneNumber.Substring(3, 3),
                phoneNumber.Substring(6, 4));
        }


        private void PhoneNumberLabel_Focused(object sender, FocusEventArgs e)
        {
            phoneNumberLabel.CursorPosition = 2;
        }

        private void PhoneNumberLabel_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneNumberLabel.Text))
            {
                phoneNumberLabel.Text = string.Empty;
            }
        }


    }
}

