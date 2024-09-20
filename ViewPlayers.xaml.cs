using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for ViewPlayers.xaml
    /// </summary>
    public partial class ViewPlayers : Window
    {
        public ViewPlayers()
        {
            InitializeComponent();
        }

        private void backtodash_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void Searchbtn2_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.SearchTabeForSJ(searchtxtbox2.Text, dataGrid);//button to view all based on ID
        }

        private void viewjuniorbtn_Click(object sender, RoutedEventArgs e)
        {

            SQLiteDataAccess.ViewAllJunior(dataGrid);
        }

        private void viewseniorbtn_Click(object sender, RoutedEventArgs e)
        {

            SQLiteDataAccess.ViewAllSenior(dataGrid);
        }
    }
}

