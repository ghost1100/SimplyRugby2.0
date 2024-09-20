using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for SeniorPlayer_dashboard.xaml
    /// </summary>
    public partial class SeniorPlayer_dashboard : Window
    {
        private static string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
        private string usernum;
        public SeniorPlayer_dashboard(string Usernum)
        {
            this.usernum = Usernum;
            InitializeComponent();
            string FullName = showSeniorName(Usernum);
            nametxtblk.Text = (" User: " + FullName);
        }

        private static string showSeniorName(string usernum)
        {
            string FullName = string.Empty;

            using (var Connection = new SQLiteConnection(ConnectionString))
            {

                string Query = "SELECT SPlayer_FirstName, SPlayer_LastName FROM SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";
                try
                {

                    Connection.Open();
                    using var Command = new SQLiteCommand(Query, Connection);
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@SPlayerID", usernum);
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
        private void viewskillsbten_Click(object sender, RoutedEventArgs e)
        {
            LoginIDs.ViewSeniorSKills(usernum, SeniorGrid);
        }

        private void ViewContactsbtn_Click(object sender, RoutedEventArgs e)
        {
            LoginIDs.ViewSeniorContacts(usernum, SeniorGrid);
        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
