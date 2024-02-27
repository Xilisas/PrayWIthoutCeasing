namespace PrayWIthoutCeasing;

public partial class PickTemplatePage : ContentPage
{
    public string SelectedTemplate { get; set; } = "Gratitude";
    public PickTemplatePage()
	{
		InitializeComponent();
	}
    
    
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }

    private async void OnNavigateToJournalEntryClicked(object sender, EventArgs e)
    {



       
            

            await Navigation.PushAsync(new JournalEntryPage(SelectedTemplate));
      
    }
}