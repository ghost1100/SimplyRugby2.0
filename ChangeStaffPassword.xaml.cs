using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for ChangeStaffPassword.xaml
    /// </summary>
    public partial class ChangeStaffPassword : Window
    {
        public ChangeStaffPassword()
        {
            InitializeComponent();
        }

        private void DashReturn1_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void Confirm2_Click(object sender, RoutedEventArgs e)
        {
            if (StaffChange.IsChecked == true)
            {
                SQLiteDataAccess.ChangeCoachesPassword(CoachUsernametxtbox.Text, CoachPasstxtbox.Text);
            }
            else
            {
                SQLiteDataAccess.ChangeStaffPassword(CoachUsernametxtbox.Text, CoachPasstxtbox.Text);

            }
        }
    }
}
// there is no error detection if you try to change the password of a coach meanwhile not checking the box assigned for it the changes you make wont take effect
//how ever a message informing you that the changes were successfull will show up anyway i could by pass that by creating another query with if statments that says if the ID in the text box has a password that doesnt match the one thats currently in the other text box display message saying try again or so, how ever if it does match it where the else statment comes in then display the message to show that the operation was a success
// reminder!! Go over these sections later on to improve the code.. however right now i will stick to the brief as much as possible so as to not waste any time... i have 2 days left for the submission maybe less
