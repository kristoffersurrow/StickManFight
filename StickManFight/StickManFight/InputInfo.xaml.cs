using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace StickManFight
{
    /// <summary>
    /// Interaction logic for InputInfo.xaml
    /// </summary>
    public partial class InputInfo : Page
    {
        public InputInfo()
        {
            InitializeComponent();
            
        }

        //Eventhandlers
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            string nation1 = null;
            string nation2 = null;

            try
            {
                nation1 = ((TextBlock)((StackPanel)((ComboBoxItem)ComboBox1.SelectedItem).Content).Children[1]).Text;
                nation2 = ((TextBlock)((StackPanel)((ComboBoxItem)ComboBox2.SelectedItem).Content).Children[1]).Text;
            }
            catch (Exception)
            { }

            Controller.CreateNewStickMan(Name1.Text, nation1);
            Controller.CreateNewStickMan(Name2.Text, nation2);


            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("InputStats.xaml", UriKind.Relative));
        }
        
    }
}
