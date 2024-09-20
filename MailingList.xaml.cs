using System.Data.SQLite;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for MailingList.xaml
    /// </summary>
    public partial class MailingList : Window
    {

        public MailingList()
        {
            InitializeComponent();

        }

        private void Backtodash_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void exportlstbtn_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            using var Connection = new SQLiteConnection(ConnectionString);


            if (Everyone.IsChecked == true)
            {
                SQLiteDataAccess.ExportEveryoneMailingList();

            }
            if (CoachesOnly.IsChecked == true)
            {
                SQLiteDataAccess.ExportCoachesMailingList();
            }
            if (AllPlayers.IsChecked == true)
            {
                SQLiteDataAccess.ExportAllPlayersMailingList();
            }
            if (SeniorOnly.IsChecked == true)
            {
                SQLiteDataAccess.ExportSeniorMailingList();
            }
            if (JuniorsOnly.IsChecked == true)
            {
                SQLiteDataAccess.ExportJuniorMailingList();
            }
            if (Staffonly.IsChecked == true)
            {
                SQLiteDataAccess.ExportStaffMailingList();
            }
            if (SeniorOnly.IsChecked == false && JuniorsOnly.IsChecked == false && AllPlayers.IsChecked == false && Staffonly.IsChecked == false && CoachesOnly.IsChecked == false && Everyone.IsChecked == false)
            {
                MessageBox.Show("No Check Boxes Used, No list will be Exported");
            }
        }
        // this second button will be used to update the list boxes.
        private void Viewselectbtn_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            using var Connection = new SQLiteConnection(ConnectionString);
            try
            {
                if (Everyone.IsChecked == true)
                {
                    lstbox1.Items.Clear();
                    SQLiteDataAccess.DispayAllMail(lstbox1);//leave it with lstbox1
                }
                if (AllPlayers.IsChecked == true)//leave it with lstbox1
                {
                    lstbox1.Items.Clear();
                    SQLiteDataAccess.DispayAllPlayersMail(lstbox1);
                }

                if (CoachesOnly.IsChecked == true)
                {

                    SQLiteDataAccess.DispayAllCoachesMail(lstbox2);//lstbox2 is now used
                }
                if (Staffonly.IsChecked == true)
                {

                    SQLiteDataAccess.DispayAllStaffMail(lstbox3);//lst box 3 is now used
                }
                //still need to make these here.
                if (SeniorOnly.IsChecked == true)
                {

                    SQLiteDataAccess.DispayAllSeniorMail(lstbox4);//lst box 4 is now in use
                }

                if (JuniorsOnly.IsChecked == true)
                {

                    SQLiteDataAccess.DispayAllJuniorMail(lstbox5);//lst box 5 is now in use
                }

                if (SeniorOnly.IsChecked == false && JuniorsOnly.IsChecked == false && AllPlayers.IsChecked == false && Staffonly.IsChecked == false && CoachesOnly.IsChecked == false && Everyone.IsChecked == false)
                {
                    MessageBox.Show("No Check Boxes Used No list will be Displayed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Ignore this message to view the sections again simply go back to dashboard and redo it this doesnt effect the export.");
            }
            finally
            {
                Connection.Close();
            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            lstbox5.ItemsSource = null;
            lstbox4.ItemsSource = null;
                lstbox3.ItemsSource = null;
            lstbox2.ItemsSource = null;
            lstbox1.ItemsSource = null;

        }
    }
}// calling the functions based on the desired conditions being met such as only calling junior players when the user chooses to export a mailing list for only junior players.


