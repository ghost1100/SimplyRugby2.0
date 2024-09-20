using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for StaffEmergency.xaml
    /// </summary>
    public partial class StaffEmergency : Window
    {
        public StaffEmergency()
        {
            InitializeComponent();
        }
        private void DashReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }
        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.SearchStaffContacts(searchtxtbox.Text, ContactsDataGrid);
        }
    }
}
