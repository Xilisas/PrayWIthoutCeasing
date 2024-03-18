namespace PrayWIthoutCeasing;

public partial class AdorationPrayerPage : ContentPage
{
    public AdorationPrayerPage()
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
        string titlePrefix = "Adoration Prayer - ";
        string dateString = DateTime.Now.ToString("MM-dd-yyyy");
        Title = titlePrefix + dateString;
        
    }
}