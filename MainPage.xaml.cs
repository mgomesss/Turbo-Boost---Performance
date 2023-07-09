using Turbo_Boost___Performance.Pages.DashBoard;

namespace Turbo_Boost___Performance
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void AbrirLinkedIn(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://www.linkedin.com/in/m-gomesss/"));
        }

        private async void AbrirGithub(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://github.com/mgomesss"));
        }

        private async void DashBoard(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TipoDeOtimizacao());
        }
    }
}
