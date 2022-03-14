using Metrology.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Metrology.Views
{
    /// <summary>
    /// Interaction logic for HandOverModalView.xaml
    /// </summary>
    public partial class HandOverModalView : Window
    {
        public HandOverModalView()
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
