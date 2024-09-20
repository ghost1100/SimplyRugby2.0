using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;



public static class LoginIDs
{
    private static string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";

    public static void ViewJuinoirsSKills(String Usernum, DataGrid JuniorDataViewer)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string Query = "SELECT JPlayer_ID, Skill_Name, Skill_Proficiency, JPlayer_FirstName, JPlayer_LastName,Passing, Kicking, Tackling FROM SkillLevels WHERE JPlayer_ID = @JPlayerID;";
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(Query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@JPlayerID", Usernum);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            JuniorDataViewer.ItemsSource = dt.DefaultView;

        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }

        finally { Connection.Close(); }
    }
    public static void ViewJuinoirsContacts(String Usernum, DataGrid JuniorDataViewer)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string Query = "SELECT Contact_ID, Contact_FirstName, Contact_Number, Contact_Address,Contact_Email, Contact_DOB FROM EmergencyContacts WHERE JPlayer_ID = @JPlayerID;";
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(Query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@JPlayerID", Usernum);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            JuniorDataViewer.ItemsSource = dt.DefaultView;

        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }

        finally { Connection.Close(); }
    }

    public static void ViewSeniorSKills(String Usernum, DataGrid SeniorGrid)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string Query = "SELECT SPlayer_ID, Skill_Name, Skill_Proficiency, SPlayer_FirstName, SPlayer_LastName,Passing, Kicking, Tackling FROM SkillLevels WHERE SPlayer_ID = @SPlayerID;";
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(Query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@SPlayerID", Usernum);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SeniorGrid.ItemsSource = dt.DefaultView;

        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }

        finally { Connection.Close(); }
    }

    public static void ViewSeniorContacts(String Usernum, DataGrid SeniorGrid)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string Query = "SELECT Contact_ID, Contact_FirstName, Contact_Number, Contact_Address,Contact_Email, Contact_DOB FROM EmergencyContacts WHERE SPlayer_ID = @SPlayerID;";
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(Query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@SPlayerID", Usernum);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SeniorGrid.ItemsSource = dt.DefaultView;

        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }

        finally { Connection.Close(); }
    }
}
