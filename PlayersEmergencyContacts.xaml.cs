using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for PlayersEmergencyContacts.xaml
    /// </summary>
    public partial class PlayersEmergencyContacts : Window
    {
        public PlayersEmergencyContacts()
        {
            InitializeComponent();
        }
        private void BacktoDashbrdbtn_Click_1(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }
        private void SearchContacts_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.SearchContacts(ContactsSearch.Text, DataGrid);// for some reason visual studio doesnt like the data grid being typed first either thats because of the order i immplemented it in the other class or its just a constant thing... 
        }
    }
}
