using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information()
        {
            InitializeComponent();
        }

        private void DashReturn12_Click(object sender, RoutedEventArgs e)
        {
            Coach_dashboard dashboard = new Coach_dashboard();
            dashboard.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (seniorplayerchecker11.IsChecked == true)
            {
                SQLiteDataAccess.AddSeniorToSquadA(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
            else
            {
                SQLiteDataAccess.AddJuniorToSquadA(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (seniorplayerchecker11.IsChecked == true)
            {
                SQLiteDataAccess.AddSeniorToSquadB(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
            else
            {
                SQLiteDataAccess.AddJuniorToSquadB(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (seniorplayerchecker11.IsChecked == true)
            {
                SQLiteDataAccess.AddSeniorToSquadC(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
            else
            {
                SQLiteDataAccess.AddJuniorToSquadC(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (seniorplayerchecker11.IsChecked == true)
            {
                SQLiteDataAccess.AddSeniorToSquadD(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
            else
            {
                SQLiteDataAccess.AddJuniorToSquadD(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (seniorplayerchecker11.IsChecked == true)
            {
                SQLiteDataAccess.AddSeniorToSquadE(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
            else
            {
                SQLiteDataAccess.AddJuniorToSquadE(PlayerId12.Text, PlayerFirstname22.Text, PlayerLastname22.Text, newSquadID.Text, Commentssection.Text);
            }
        }
        // above was the add to squads section below is the delete from squads section.
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.ClearSquadA();
        }
        private void ClearSquadbtnB_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.ClearSquadB();

        }

        private void ClearSquadbtnC_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.ClearSquadC();
        }

        private void ClearSquadbtnD_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.ClearSquadD();
        }
        private void ClearSquadbtnE_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.ClearSquadE();
        }

        // clear all fields button
        private void clearFields_Click(object sender, RoutedEventArgs e)
        {
            PlayerdeleteID.Clear();
            Commentssection.Clear();
            PlayerLastname22.Clear();
            PlayerFirstname22.Clear();
            PlayerFirstname22.Clear();
            newSquadID.Clear();
            PlayerId12.Clear();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            if (deletesplayerssqd.IsChecked == true)
            {
                SQLiteDataAccess.DeleteFromSquadOnIDSPlayer(PlayerdeleteID.Text);
            }
            else
            {
                SQLiteDataAccess.DeleteFromSquadOnIDJPlayer(PlayerdeleteID.Text);
            }






        }
    }
}