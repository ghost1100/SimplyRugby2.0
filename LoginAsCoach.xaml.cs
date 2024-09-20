using System.Data;
using System.Data.SQLite;
using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for LoginAsCoach.xaml
    /// </summary>
    public partial class LoginAsCoach : Window
    {
        public LoginAsCoach()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            string query = "select Count(*) from Login where Coaches_ID=@Coaches_ID AND Passwords=@Passwords";
            using var Connection = new SQLiteConnection(connectionString);
            try
            {
                Connection.Open();
                var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Coaches_ID", CoachUsername.Text);
                    Command.Parameters.AddWithValue("@Passwords", CoachPassword.Text);

                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    Command.ExecuteNonQuery();
                    if (count == 1)
                    {
                        Coach_dashboard Dashboard = new Coach_dashboard();
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


