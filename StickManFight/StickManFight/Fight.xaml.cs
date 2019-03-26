using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace StickManFight
{
    /// <summary>
    /// Interaction logic for Fight.xaml
    /// </summary>
    public partial class Fight : Page
    {
        //Instansvariabler og Objekter initialiseres og instantieres
        int counter;
        StickManStats f1 = (StickManStats)Controller.GetStickMan(0);
        StickManStats f2 = (StickManStats)Controller.GetStickMan(1);
        
        public Fight()
        {
            InitializeComponent();

            //Healthbar højde sættes
            HP1.Height = Controller.HealthBarSet(f1);
            HPbg1.Height = Controller.HealthBarSet(f1);
            HP2.Height = Controller.HealthBarSet(f2);
            HPbg2.Height = Controller.HealthBarSet(f2);

            //Timer igangsættes
            TimeOut(11);
        }

        //Eventhandlers
        //damage returneres mens denne fratrækkes Health
        //Healthbar sættes og farve checkes
        //Billeder ændres og en timer sættes
        //Angrebsinformation tilføjes til overbliksliste
        //Angrebsknapper disables
        private void Attack1Button_Click(object sender, RoutedEventArgs e)
        {
            int damage = Controller.Fight(f1, f2);
            HP2.Height = Controller.HealthBarSet(f2);

            Controller.AddInfoToOverview(f1, f2, damage);

            if (f2.Health > 0)
            {
                FighterImg1.Source = new BitmapImage(new Uri(@"./Resources/Attack1.png",UriKind.Relative));
                FighterImg2.Source = new BitmapImage(new Uri(@"./Resources/Block2.png", UriKind.Relative));
                
                CheckHealth(HP2);

                ButtonsEnabled(false);


                TimeOut(Controller.GenerateRandom(6));
            }
            else
            {
                FighterImg2.Source = new BitmapImage(new Uri(@"./Resources/Dead2.png", UriKind.Relative));
                Header.Text = String.Format("The Winner is {0}", f1.GenerateInfo());

                Controller.GetFightOverview().Add(StickManStats.GenerateWinnerInfo(f1,f2));

                ButtonsEnabled(false);

                OverviewButton.Visibility = Visibility.Visible;
            }
        }

        //damage returneres mens denne fratrækkes Health
        //Healthbar sættes og farve checkes
        //Billeder ændres og en timer sættes
        //Angrebsinformation tilføjes til overbliksliste
        //Angrebsknapper disables
        private void Attack2Button_Click(object sender, RoutedEventArgs e)
        {
            int damage = Controller.Fight(f2, f1);
            HP1.Height = Controller.HealthBarSet(f1);

            Controller.AddInfoToOverview(f2, f1, damage);

            if (f1.Health > 0)
            {
                FighterImg1.Source = new BitmapImage(new Uri(@"./Resources/Block1.png", UriKind.Relative));
                FighterImg2.Source = new BitmapImage(new Uri(@"./Resources/Attack2.png", UriKind.Relative));

                CheckHealth(HP1);

                ButtonsEnabled(false);

                TimeOut(Controller.GenerateRandom(6));
            }
            else
            {
                FighterImg1.Source = new BitmapImage(new Uri(@"./Resources/Dead1.png", UriKind.Relative));
                Header.Text = String.Format("The Winner is {0}", f2.GenerateInfo());

                Controller.GetFightOverview().Add(StickManStats.GenerateWinnerInfo(f2, f1));

                ButtonsEnabled(false);

                OverviewButton.Visibility = Visibility.Visible;
            }
        }

        //Eventhandler
        private void OverviewButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Overview.xaml", UriKind.Relative));
        }

        //Metoder
        //Sætter timer
        private void TimeOut(int time)
        {
            counter = time;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        //Eventhandler for hvert sekund af timer
        //Ændrer teksten i headeren
        //Ændrer billeder når counter er 0
        private void Timer_Tick(object sender, EventArgs e)
        {
            DispatcherTimer timer = (DispatcherTimer)sender;
            counter--;
            string text = "READY IN - ";
            text += counter.ToString();
            Header.Text = text;

            if (counter == 0)
            {
                timer.Stop();
                Header.Text = "FIGHT!";
                FighterImg1.Source = new BitmapImage(new Uri(@"./Resources/Idle1.png", UriKind.Relative));
                FighterImg2.Source = new BitmapImage(new Uri(@"./Resources/Idle2.png", UriKind.Relative));

                ButtonsEnabled(true);
            }
        }

        //Metode 
        //Skifter Healthbar farve hvis under 50 og 20
        private void CheckHealth(System.Windows.Shapes.Rectangle hp)
        {
            if (hp.Height < 20)
            {
                hp.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (hp.Height < 50)
            {
                hp.Fill = new SolidColorBrush(Colors.Yellow);
            }
        }

        //Enabler eller Disabler angrebsknapper
        private void ButtonsEnabled(bool enabled)
        {
            Btn1.IsEnabled = enabled;
            Btn2.IsEnabled = enabled;
        }
    }
}
