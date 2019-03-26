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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StickManFight
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void QuickFightButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.CreateNewStickMan("Fighter1", null);
            Controller.CreateNewStickMan("Fighter2", null);

            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Fight.xaml", UriKind.Relative));

        }

        private void CustomFightButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("InputInfo.xaml", UriKind.Relative));

        }

        private void FightHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("History.xaml", UriKind.Relative));

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
