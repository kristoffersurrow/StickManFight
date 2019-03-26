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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();

            Scrollviewer.Content = Controller.ReadFromHistoryFile();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("MainMenu.xaml", UriKind.Relative));
        }

        private void ClearHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.ClearToHistoryFile();

            Scrollviewer.Content = Controller.ReadFromHistoryFile();
        }
    }
}
