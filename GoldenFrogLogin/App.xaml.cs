using GoldenFrogLogin.ViewModel;
using System.Windows;

namespace GoldenFrogLogin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.DataContext = new LoginViewModel();
            loginView.Show();
        } 
    }
}
