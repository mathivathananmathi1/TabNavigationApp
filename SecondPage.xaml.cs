
using System.Windows;
using System.Windows.Controls;

namespace TabNavigationApp
{
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
