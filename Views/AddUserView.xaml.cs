using Metrology.Definitions;
using System.Windows;

namespace Metrology.Views
{
    public partial class AddUserView : Window
    {
        public AddUserView()
        {
            InitializeComponent();
            Loaded += Authorization_Loaded;
        }
        private void Authorization_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is IWindowInteraction wi)
            {
                wi.Close += () => { this.Close(); };
            }
        }
    }
}