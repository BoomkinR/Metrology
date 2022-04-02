using System.Windows;
using Metrology.Definitions;

namespace Metrology.Views.AddViews
{
    /// <summary>
    /// Interaction logic for AddRoleView.xaml
    /// </summary>
    public partial class AddRoleView : Window
    {
        public AddRoleView()
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
