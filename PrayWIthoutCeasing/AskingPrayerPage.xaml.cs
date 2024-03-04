namespace PrayWIthoutCeasing;

public partial class AskingPrayerPage : ContentPage
{
    public AskingPrayerPage()
    {
        InitializeComponent();
    }
    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PickTemplatePage());
    }

}