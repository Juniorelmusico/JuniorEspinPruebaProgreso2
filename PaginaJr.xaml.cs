namespace JuniorEspinPruebaProgreso2;

public partial class NewPage1 : ContentPage
{
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}
public System.Threading.Tasks.Task<bool> DisplayAlert(string title, string message, string accept, string cancel, Microsoft.Maui.FlowDirection flowDirection);