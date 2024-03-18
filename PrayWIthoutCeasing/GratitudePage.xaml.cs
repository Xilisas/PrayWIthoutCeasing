
namespace PrayWIthoutCeasing;

public partial class GratitudePage: ContentPage
{
   
    private List<PrayerEntry> _prayers;
     public GratitudePage()
    {
        InitializeComponent();
        SetPageTitle();
        
    }
	
    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PickTemplatePage());
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        
        
    }
    private void SetPageTitle()
    {
        string titlePrefix = "Gratitude Prayer - ";
        string dateString = DateTime.Now.ToString("MM-dd-yyyy");
        Title = titlePrefix + dateString;

    }

    public void SaveEntry(string title, string content)
    {
        string key = title;
        Preferences.Set(key, content);
    }
    private async void OnSave(object sender, EventArgs e)
    {
        SaveEntry(Title, Q1 + "\n" + A1 + "\n" + Q2 + "\n" + A2 + "\n" + Q3 + "\n" + A3 + "\n" + Q4 + "\n" + A4 + "\n"  + Q5 + "\n" + A5 + "\n");
    }

}