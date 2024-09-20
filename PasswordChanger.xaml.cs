using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for PasswordChanger.xaml
    /// </summary>
    public partial class PasswordChanger : Window
    {
        public PasswordChanger()
        {
            InitializeComponent();
        }
        private void BacktoDashBtn_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (chkbox2.IsChecked == true)
            {

                SQLiteDataAccess.UpdateSeniorLogin(UserID.Text, UserPassword.Text);
            }
            else
            {
                SQLiteDataAccess.UpdateJuniorLogin(UserID.Text, UserPassword.Text);
            }
        }


    }
}
