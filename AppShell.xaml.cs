
namespace JuniorEspinPruebaProgreso2
{
    public partial class AppShell : Shell
    {
        private async void LearnMore_Clicked(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
        }
    }
}
