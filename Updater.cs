using SimplyRugby2._0;
using System.Data;
using System.Data.SQLite;
using System.Drawing.Design;
using System.IO;
using System.Windows;
using System.Windows.Controls;


public static class Updater
{

    private static string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";

    public static void UpdateCoachesNumber(string srchtxtbx, string ChangeNumber)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeNumber))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update Coaches Set Coaches_Number = @Coaches_Number where Coaches_ID = @Coaches_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        {
            try
            {

                Connection.Open();
                using var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Coaches_ID", srchtxtbx);
                    Command.Parameters.AddWithValue("@Coaches_Number", ChangeNumber);

                    int rowseffected = Command.ExecuteNonQuery();
                    if (rowseffected == 1)
                    {
                        MessageBox.Show("Phone Number Changed Successfully");

                    }
                    else
                    {
                        MessageBox.Show("User With this ID not found or doesnt exist");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }


    }
    public static void UpdateSPNumber(string srchtxtbx, string ChangeNumber)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeNumber))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update SeniorPlayers Set SPlayer_Number = @SPlayer_Number where SPlayer_ID = @SPlayer_ID";
        using (var Connection = new SQLiteConnection(ConnectionString))
        {
            try
            {

                Connection.Open();
                using var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@SPlayer_ID", srchtxtbx);
                    Command.Parameters.AddWithValue("@SPlayer_Number", ChangeNumber);

                    int rowseffected = Command.ExecuteNonQuery();
                    if (rowseffected == 1)
                    {
                        MessageBox.Show("Phone Number Changed Successfully");

                    }
                    else
                    {
                        MessageBox.Show("User With this ID not found or doesnt exist");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }


    }

    public static void UpdateJPNumber(string srchtxtbx, string ChangeNumber)

    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeNumber))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update JuniorPlayers Set JPlayer_Number = @JPlayer_Number where JPlayer_ID = @JPlayer_ID";
        using (var Connection = new SQLiteConnection(ConnectionString))
        {
            try
            {

                Connection.Open();
                using var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@JPlayer_ID", srchtxtbx);
                    Command.Parameters.AddWithValue("@JPlayer_Number", ChangeNumber);

                    int rowseffected = Command.ExecuteNonQuery();
                    if (rowseffected == 1)
                    {
                        MessageBox.Show("Phone Number Changed Successfully");

                    }
                    else
                    {
                        MessageBox.Show("User With this ID not found or doesnt exist");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }


    }
    public static void UpdateStaffNumber(string srchtxtbx, string ChangeNumber)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeNumber))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update Staff Set Staff_Number = @Staff_Number where Staff_ID = @Staff_ID";
        using (var Connection = new SQLiteConnection(ConnectionString))
        {
            try
            {

                Connection.Open();
                using var Command = new SQLiteCommand(query, Connection);
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Staff_ID", srchtxtbx);
                    Command.Parameters.AddWithValue("@Staff_Number", ChangeNumber);

                    int rowseffected = Command.ExecuteNonQuery();
                    if (rowseffected == 1)
                    {
                        MessageBox.Show("Phone Number Changed Successfully");

                    }
                    else
                    {
                        MessageBox.Show("User With this ID not found or doesnt exist");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }


    }

    public static void UpdateCoachesAddress(string srchtxtbx, string ChangeAddress)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeAddress))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update Coaches Set Coaches_Address = @Coaches_Address where Coaches_ID = @Coaches_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Coaches_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@Coaches_Address", ChangeAddress);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show(" Address Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }

    public static void UpdateSeniorPlayersAddress(string srchtxtbx, string ChangeAddress)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeAddress))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update SeniorPlayers Set SPlayer_Address = @SPlayer_Address where SPlayer_ID = @SPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@SPlayer_Address", ChangeAddress);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show(" Address Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }


    public static void UpdateJuniorPlayersAddress(string srchtxtbx, string ChangeAddress)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeAddress))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update JuniorPlayers Set JPlayer_Address = @JPlayer_Address where JPlayer_ID = @JPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@JPlayer_Address", ChangeAddress);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show(" Address Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }


    public static void UpdateStaffAddress(string srchtxtbx, string ChangeAddress)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeAddress))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update Staff Set Staff_Address = @Staff_Address where Staff_ID = @Staff_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Staff_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@Staff_Address", ChangeAddress);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show(" Address Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }

    public static void UpdateSeniorPlayersEmail(string srchtxtbx, string ChangeEmail)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeEmail))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update SeniorPlayers Set SPlayer_Email = @SPlayer_Email where SPlayer_ID = @SPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@SPlayer_Email", ChangeEmail);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show("Email Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }

    public static void UpdateJuniorPlayersEmail(string srchtxtbx, string ChangeEmail)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeEmail))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update JuniorPlayers Set JPlayer_Email = @JPlayer_Email where JPlayer_ID = @JPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@JPlayer_Email", ChangeEmail);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show("Email Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }





    public static void UpdateStaffEmail(string srchtxtbx, string ChangeEmail)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeEmail))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update Staff Set Staff_Email = @Staff_Email where Staff_ID = @Staff_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Staff_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@Staff_Email", ChangeEmail);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show("Email Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }










    public static void UpdateCoachesEmail(string srchtxtbx, string ChangeEmail)
    {
        if (string.IsNullOrEmpty(srchtxtbx) || string.IsNullOrEmpty(ChangeEmail))
        {
            MessageBox.Show("Text Box is empty");
            return;
        }
        string query = "Update Coaches Set Coaches_Email = @Coaches_Email where Coaches_ID = @Coaches_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Coaches_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@Coaches_Email", ChangeEmail);

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show("Email Changed Successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }
    public static void DeleteEmergencyContact(string srchtxtbx)
    {

        string query = "Delete From  EmergencyContacts where Coaches_ID = @Coaches_ID OR SPlayer_ID =@SPlayer_ID  OR JPlayer_ID =@JPlayer_ID OR Staff_ID = @Staff_ID; ";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;

                Command.Parameters.AddWithValue("@Coaches_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@SPlayer_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@JPlayer_ID", srchtxtbx);
                Command.Parameters.AddWithValue("@Staff_ID", srchtxtbx);
                //try this


                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 1)
                {
                    MessageBox.Show("contacts deleted successfully");

                }
                else
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");

                }
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }

    }


}

