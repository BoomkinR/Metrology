using System.Windows;
using Metrology.Definitions;

namespace Metrology.Views.AddViews
{
    public partial class AddOrganizationsModalView : Window
    {
        public AddOrganizationsModalView()
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