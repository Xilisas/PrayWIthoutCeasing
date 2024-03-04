namespace PrayWIthoutCeasing;

public partial class AdorationPrayerPage : ContentPage
{
    public AdorationPrayerPage()
    {
        InitializeComponent();
    }
    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PickTemplatePage());
    }
}