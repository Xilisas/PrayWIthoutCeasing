namespace PrayWIthoutCeasing;

public partial class GratitudePage: ContentPage
{
	public GratitudePage()
	{
		InitializeComponent();
	}
    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PickTemplatePage());
    }
}