namespace PrayWIthoutCeasing;

public partial class PickTemplatePage : ContentPage
{
    public string SelectedTemplate { get; set; } = "Gratitude";
    public int selectedValue { get; set; }
    public PickTemplatePage()
	{
		InitializeComponent();
	}
    public class PickerItem
    {
        public required string  DisplayText { get; set; }
        public int Value { get; set; }
    }
    List<PickerItem> pickerItems = new List<PickerItem>()
{
    new PickerItem { DisplayText = "Gratitude", Value = 1 },
    new PickerItem { DisplayText = "Adoration", Value = 2 },
    new PickerItem { DisplayText = "Asking", Value = 3 }
    
};
    private void OnPickerSelectionChanged(object sender, EventArgs e)
{
    PickerItem selectedPickerItem = (PickerItem)myPicker.SelectedItem;
     selectedValue = selectedPickerItem.Value;

    // Use the selected integer value as needed
}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }

    private async void OnNavigateToJournalEntryClicked(object sender, EventArgs e)
    {
        if (myPicker.SelectedIndex + 1 == 1)
        {
            await Navigation.PushAsync(new GratitudePage());
        }
        else if(selectedValue + 1 == 2) 
        {
            await Navigation.PushAsync(new AdorationPage());
        }
        else if(selectedValue + 1 == 3)
        {
            await Navigation.PushAsync (new AskingPage());
        }
      
    }
}