using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for DeleteStaffOrCoach.xaml
    /// </summary>
    public partial class DeleteStaffOrCoach : Window
    {
        public DeleteStaffOrCoach()
        {
            InitializeComponent();
        }

        private void DashReturnbtn_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void SearchTablesbtn_Click(object sender, RoutedEventArgs e)
        {

            SQLiteDataAccess.SearchStaffOrCoaches(StaffIDtxtbox.Text, CoachDataGrid);


        }

        private void DeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DeleteFromCoachesOrStaff(StaffIDtxtbox.Text);
        }
    }
}


