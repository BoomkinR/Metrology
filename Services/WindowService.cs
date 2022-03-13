using Metrology.ViewModels;
using Metrology;
using System.Windows;
using Metrology.Views;

namespace Metrology.Services
{
    internal class WindowService
    {
        public void ShowMainWindow()
        {
            // роли
            var viewModel = new Layout();
            var metrologyView= new MetrologyStartApp() { DataContext = viewModel};
            metrologyView.Show();
            
        }
        
        public void ShowAddUserView()
        {
            // роли
            var viewModel = new AddUserViewModel();
            var view= new AddUserView(){ DataContext = viewModel};
            view.ShowDialog();
        }

        public void ShowAddDeviceModalView()
        {
            var viewModel = new AddDeviceViewModel();
            var view= new AddDeviceModalView() { DataContext = viewModel};
            view.ShowDialog();
        }

        public void ShowHandOverModalView()
        {

        }

    }
}
