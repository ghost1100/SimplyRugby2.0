using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for LoginAsSecretary.xaml
    /// </summary>
    public partial class LoginAsSecretary : Window
    {
        public LoginAsSecretary()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            string query = "select Count(*) from Login where Staff_ID=@Staff_ID AND Passwords=@Passwords";
            using var Connection = new SQLiteConnection(connectionString);
            try
            {
                Connection.Open();
                var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Staff_ID", SecretaryUsername.Text);
                    Command.Parameters.AddWithValue("@Passwords", SecretaryPassword.Text);

                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    Command.ExecuteNonQuery();
                    if (count == 1)
                    {
                        Secretary_dashboard Dashboard = new Secretary_dashboard();
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
