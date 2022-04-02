using System.Windows;
using Metrology.ViewModels;
using Metrology.Views;

namespace Metrology
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void ApplicationStartup(object sender, StartupEventArgs args)
        {
            var window = new Authorization();  
            window.DataContext = new AuthorizationViewModel();
            window.Show();
        }
        
    }
}
