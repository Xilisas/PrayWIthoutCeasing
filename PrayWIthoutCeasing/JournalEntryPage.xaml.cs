namespace PrayWIthoutCeasing;

public partial class JournalEntryPage : ContentPage
{
    public string SelectedTemplate {  get; set; }
    public string JournalEntryContent { get; set; } = string.Empty;
    public JournalEntryPage(string Template)
	{
        
		InitializeComponent();
        SelectedTemplate = Template;
	}
   
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Access the selected template here and use it
        if (!string.IsNullOrEmpty(SelectedTemplate))
        {
            LoadTemplateContent();
        }
        
    }
    private void LoadTemplateContent()
    {
        // Load content of the selected template into the journal entry field
        // This could involve reading content from a file or accessing a data source
        // For example:
        JournalEntryContent = LoadContentFromFile(SelectedTemplate);

        // Update the UI to display the loaded content
        JournalEntryField.Text = JournalEntryContent;
    }

    private string LoadContentFromFile(string templateFileName)
    {
        // Implement logic to load content from the selected template file
        // For example, read content from a text file
        string filePath =  templateFileName;
        string content = File.ReadAllText("C:/Users/cjree/source/repos/PrayWIthoutCeasing/PrayWIthoutCeasing/Gratitude.txt");
        return content;
    }
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}