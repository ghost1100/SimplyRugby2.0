using System.Data;
using System.Data.SQLite;
using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for LoginAsSeniorPlayer.xaml
    /// </summary>
    public partial class LoginAsSeniorPlayer : Window
    {
        public LoginAsSeniorPlayer()
        {
            InitializeComponent();
        }
        private string Usernum;
        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            Usernum = SPlayerUsername.Text;
            var SeniorPlayer_dashboard = new SeniorPlayer_dashboard(Usernum);
            string connectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            string query = "select Count(*) from Login where SPlayer_ID=@SPlayer_ID AND Passwords=@Passwords";
            using var Connection = new SQLiteConnection(connectionString);

            try
            {
                Connection.Open();
                var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@SPlayer_ID", SPlayerUsername.Text);
                    Command.Parameters.AddWithValue("@Passwords", SPlayerPassword.Text);

                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    Command.ExecuteNonQuery();
                    if (count == 1)
                    {
                        SeniorPlayer_dashboard Dashboard = new SeniorPlayer_dashboard(Usernum);
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
