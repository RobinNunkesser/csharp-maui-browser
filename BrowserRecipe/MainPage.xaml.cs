namespace BrowserRecipe;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.microsoft.com");
            BrowserLaunchOptions options =
                new BrowserLaunchOptions()
                {
                    LaunchMode = BrowserLaunchMode.SystemPreferred,
                    TitleMode = BrowserTitleMode.Show
                };

            await Browser.Default.OpenAsync(uri, options);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }
}
