using System.Windows.Controls;

namespace Ddd.UI.Common
{
    /// <summary>
    /// Interaction logic for CustomWindow.xaml
    /// </summary>
    public partial class CustomWindow : Page
    {
        public CustomWindow(ViewModel viewModel)
        {
            InitializeComponent();

            //Owner = Application.Current.MainWindow;
            DataContext = viewModel;
        }
    }
}
