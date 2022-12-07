namespace movieLogger;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void onLoginButtonClicked(object sender, EventArgs e)
    {
		DisplayAlert("Alert", "This feature will be available in the full release of this application.", "OK");
    }
}

