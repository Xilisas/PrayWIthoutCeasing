namespace PrayWIthoutCeasing;

public partial class AskingPrayerPage : ContentPage
{
    public AskingPrayerPage()
    {
        InitializeComponent();
        SetPageTitle();
    }
    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PickTemplatePage());
    }
    private void SetPageTitle()
    {
        string titlePrefix = "Asking Prayer - ";
        string dateString = DateTime.Now.ToString("MM-dd-yyyy");
        Title = titlePrefix + dateString;

    }
}