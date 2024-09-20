using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for JuniorPlayer_dashboard.xaml
    /// </summary>
    public partial class JuniorPlayer_dashboard : Window
    {
        private static string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
        // this section is simply used to show the user a welcome aboard message in their dashboard based on 
        private string usernum;
        public JuniorPlayer_dashboard(string Usernum)
        {
            InitializeComponent();
            this.usernum = Usernum;

            string FullName = showJuniorName(Usernum);
            Nametextblk.Text = (" User: " + FullName);
        }
        private static string showJuniorName(string usernum)
        {
            string FullName = string.Empty;

            using (var Connection = new SQLiteConnection(ConnectionString))
            {

                string Query = "SELECT JPlayer_FirstName, JPlayer_LastName FROM JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";
                try
                {

                    Connection.Open();
                    using var Command = new SQLiteCommand(Query, Connection);
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@JPlayerID", usernum);
                    using var reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        string FirstName = reader.GetString(0);
                        string LastName = reader.GetString(1);
                        FullName = FirstName + " " + LastName;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally { Connection.Close(); }
            }
            return FullName;


        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            this.Close();
            main.Show();

        }

        private void Viewownskills_Click(object sender, RoutedEventArgs e)
        {

            LoginIDs.ViewJuinoirsSKills(usernum, JuniorDataViewer);
        }

        private void ViewownemergencyContacts_Click(object sender, RoutedEventArgs e)
        {
            LoginIDs.ViewJuinoirsContacts(usernum, JuniorDataViewer);
        }
    }
}

