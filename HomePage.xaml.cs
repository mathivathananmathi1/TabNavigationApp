
using System.Windows;
using System.Windows.Controls;

namespace TabNavigationApp
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SecondPage());
        }
    }
}
