using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for AddPlayers.xaml
    /// </summary>
    public partial class AddPlayers : Window
    {
        public AddPlayers()
        {
            InitializeComponent();
        }

        private void backtodash3_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void AddPlayerbtn_Click(object sender, RoutedEventArgs e)
        {
            if ((!System.Text.RegularExpressions.Regex.IsMatch(PlayerEmail.Text, Regex.REGEXPattern.Emailpattern) ||
               (!System.Text.RegularExpressions.Regex.IsMatch(ContactEmail.Text, Regex.REGEXPattern.Emailpattern))))

            {


                MessageBox.Show("this users inputs are not Valid try again!!");
            }
            else
            {
                if (chkbox1.IsChecked == true)
                {
                    SQLiteDataAccess.InsertIntoSeniorPlayers(PlayerID.Text, PlayerFirstName.Text, PlayerLastName.Text, PlayerEmail.Text, PlayerAddress.Text, PlayerNumber.Text, PlayerDOB.Text);
                    SQLiteDataAccess.InsertIntoEmergencyContactsSeniors(ContactID.Text, ContactFirstName.Text, ContactLastName.Text, ContactEmail.Text, ContactAddress.Text, ContactNumber.Text, ContactDOB.Text, PlayerID.Text);

                }
                else
                {
                    SQLiteDataAccess.InsertIntoJuniorPlayers(PlayerID.Text, PlayerFirstName.Text, PlayerLastName.Text, PlayerEmail.Text, PlayerAddress.Text, PlayerNumber.Text, PlayerDOB.Text);
                    SQLiteDataAccess.InsertIntoEmergencyContactsJuniors(ContactID.Text, ContactFirstName.Text, ContactLastName.Text, ContactEmail.Text, ContactAddress.Text, ContactNumber.Text, ContactDOB.Text, PlayerID.Text);



                }
            }

        }

    }
}

//}
