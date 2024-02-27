namespace PrayWIthoutCeasing
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

       
        private async void OnNavigateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickTemplatePage());
        }

    }

}
