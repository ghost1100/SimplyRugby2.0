using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for AddStaffOrCoach.xaml
    /// </summary>
    public partial class AddStaffOrCoach : Window
    {
       
        public AddStaffOrCoach()
        {
            InitializeComponent();
        }

        private void dashbtn_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void AddStaffbtn_Click(object sender, RoutedEventArgs e)
        {
            if ((!System.Text.RegularExpressions.Regex.IsMatch(MemberEmail.Text, Regex.REGEXPattern.Emailpattern) ||
                (!System.Text.RegularExpressions.Regex.IsMatch(MemberContactEmail.Text, Regex.REGEXPattern.Emailpattern))))
              
            {


                MessageBox.Show("this users inputs are not Valid try again!!");
            }

            else
            {
                if (Coachchkbox.IsChecked == true)// if the box is ticked it will add a coach to the database
            {
                SQLiteDataAccess.InsertIntoCoaches(MemberID.Text, MemberFirstName.Text, MemberLastName.Text, MemberEmail.Text, MemberAddress.Text, MemberNumber.Text, MemberDOB.Text);
                SQLiteDataAccess.InsertIntoEmergencyContactsCoaches(MemberContactID.Text, MemberContactFirstName.Text, MemberContactLastName.Text, MemberContactEmail.Text, MemberContactAddress.Text, MemberContactNumber.Text, MemberContactDOB.Text, MemberID.Text);

            }
                 else// other wise it will add a staff member
            {
                SQLiteDataAccess.InsertIntoStaff(MemberID.Text, MemberFirstName.Text, MemberLastName.Text, MemberEmail.Text, MemberAddress.Text, MemberNumber.Text, MemberDOB.Text);
                SQLiteDataAccess.InsertIntoEmergencyContactsStaff(MemberContactID.Text, MemberContactFirstName.Text, MemberContactLastName.Text, MemberContactEmail.Text, MemberContactAddress.Text, MemberContactNumber.Text, MemberContactDOB.Text, MemberID.Text);

            }
            }
           
        }
    }
}
