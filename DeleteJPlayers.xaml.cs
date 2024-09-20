using System.Windows;

namespace SimplyRugby2._0
{

    public partial class DeleteJPlayers : Window
    {
        public DeleteJPlayers()
        {
            InitializeComponent();
        }

        private void backtodash_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }
        private void searchbtn_Click(object sender, RoutedEventArgs e)// could be used in the view all players to add a section where the quesy checks all players unless you want to see specific sections
        {

            SQLiteDataAccess.SearchbyID2(searchtxtbox.Text, dataGrid);
            // note for next time you could name all the design objects the same and make a function and a check box to search only for either senior or junior players could even inlucde the delete squad section along side it to avoid having to make as many classes as there is right now...


        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DeletePlayers(searchtxtbox.Text);
        }

    }
}