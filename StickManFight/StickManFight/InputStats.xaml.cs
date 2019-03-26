using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace StickManFight
{
    /// <summary>
    /// Interaction logic for InputStats.xaml
    /// </summary>
    public partial class InputStats : Page
    {
        //Instansvariabler og Objekter initialiseres og instantieres
        bool inputOk;
        StickManStats f1 = (StickManStats)Controller.GetStickMan(0);
        StickManStats f2 = (StickManStats)Controller.GetStickMan(1);

        public InputStats()
        {
            InitializeComponent();

            Fighter1Name.Content = f1.Name;
            Fighter2Name.Content = f2.Name;
            
        }


        //Eventhandlers
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            inputOk = true;

            InputValidation.InputVal(Health1.Text, errHealth1, ref inputOk);
            InputValidation.InputVal(Health2.Text, errHealth2, ref inputOk);
            InputValidation.InputVal(AttMax1.Text, errAttMax1, ref inputOk);
            InputValidation.InputVal(AttMax2.Text, errAttMax2, ref inputOk);
            InputValidation.InputVal(BloMax1.Text, errBloMax1, ref inputOk);
            InputValidation.InputVal(BloMax2.Text, errBloMax2, ref inputOk);
            
            if (inputOk)
            {
                StickManStats.AddStats(f1, f2, Health1.Text, AttMax1.Text, BloMax1.Text, Health2.Text, AttMax2.Text, BloMax2.Text);

                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new Uri("Fight.xaml", UriKind.Relative));
            }

        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("InputInfo.xaml", UriKind.Relative));
        }

        private void Health1_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputValidation.InputVal(Health1.Text, errHealth1);

        }

        private void Health2_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputValidation.InputVal(Health2.Text, errHealth2);

        }

        private void AttMax1_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputValidation.InputVal(AttMax1.Text, errAttMax1);

        }

        private void AttMax2_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputValidation.InputVal(AttMax2.Text, errAttMax2);

        }

        private void BloMax1_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputValidation.InputVal(BloMax1.Text, errBloMax1);

        }

        private void BloMax2_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputValidation.InputVal(BloMax2.Text, errBloMax2);

        }
    }
}
