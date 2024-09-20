using System.Data;
using System.Data.SQLite;
using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for LoginAsJuniorPlayer.xaml
    /// </summary>
    public partial class LoginAsJuniorPlayer : Window
    {
        public LoginAsJuniorPlayer()
        {
            InitializeComponent();
        }
        private string Usernum;

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            Usernum = JPlayerUsername.Text;
            var JuniorPlayer_dashboard = new JuniorPlayer_dashboard(Usernum);
            string connectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            string query = "select Count(*) from Login where JPlayer_ID = @JPlayer_ID AND Passwords= @Passwords";
            using var Connection = new SQLiteConnection(connectionString);
            try
            {
                Connection.Open();
                var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@JPlayer_ID", JPlayerUsername.Text);
                    Command.Parameters.AddWithValue("@Passwords", JPlayerPassword.Text);

                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    Command.ExecuteNonQuery();
                    if (count == 1)
                    {
                        JuniorPlayer_dashboard Dashboard = new JuniorPlayer_dashboard(Usernum);
                        Dashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your username or password may be incorrect");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

    }
}
