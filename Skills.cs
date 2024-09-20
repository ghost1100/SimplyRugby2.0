using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;


public static class Skills
{
    private static string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";

    // first skill add to junior section
    public static void JuniorStandardPassing1(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        // string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE JPlayer_ID = @JPlayerID;";
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 1;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
                Command.ExecuteNonQuery();


            }
            MessageBox.Show("Data Was Added Accordingly");
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

    public static void JuniorStandardPassing2(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        // string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE JPlayer_ID = @JPlayerID;";
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 2;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
                Command.ExecuteNonQuery();


            }
            MessageBox.Show("Data Was Added Accordingly");
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

    public static void JuniorStandardPassing3(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        // string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE JPlayer_ID = @JPlayerID;";
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 3;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
                Command.ExecuteNonQuery();


            }
            MessageBox.Show("Data Was Added Accordingly");
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
    public static void JuniorStandardPassing4(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        //  string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE JPlayer_ID = @JPlayerID;";
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 4;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
                Command.ExecuteNonQuery();



            }
            MessageBox.Show("Data Was Added Accordingly");
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
    public static void JuniorStandardPassing5(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        // string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE JPlayer_ID = @JPlayerID;";
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 5;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
                Command.ExecuteNonQuery();

            }
            MessageBox.Show("Data Was Added Accordingly");
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

    //first skill add to senior section
    public static void SeniorStandardPassing1(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        // the update appends to past records which damage my structure of the database
        //string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE SPlayer_ID = @SPlayerID;";
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 1;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
                Command.ExecuteNonQuery();


            }
            MessageBox.Show("Data Was Added Accordingly");
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

    public static void SeniorStandardPassing2(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        //  string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE SPlayer_ID = @SPlayerID;";
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 2;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
                Command.ExecuteNonQuery();


            }
            MessageBox.Show("Data Was Added Accordingly");
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

    public static void SeniorStandardPassing3(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        // string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE SPlayer_ID = @SPlayerID;";
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 3;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
                Command.ExecuteNonQuery();


            }
            MessageBox.Show("Data Was Added Accordingly");
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
    public static void SeniorStandardPassing4(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        //string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE SPlayer_ID = @SPlayerID;";
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 4;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
                Command.ExecuteNonQuery();



            }
            MessageBox.Show("Data Was Added Accordingly");
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
    public static void SeniorStandardPassing5(string Passingcomments, string Kickingcomments, string Tacklingcomments, string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        //string query = "UPDATE  SkillLevels SET Skill_Name = @Skill_Name, Skill_Proficiency = @Skill_Proficiency, Passing = @Passing, Kicking =@Kicking, Tackling= @Tackling WHERE SPlayer_ID = @SPlayerID;";
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency, Passing, Kicking, Tackling) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency, @Passing, @Kicking, @Tackling From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...

        int SkillProficiency = 5;
        string SkillName = "Passing Standard";
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
                Command.Parameters.AddWithValue("@Skill_Name", SkillName);
                Command.Parameters.AddWithValue("@Passing", Passingcomments);
                Command.Parameters.AddWithValue("@Kicking", Kickingcomments);
                Command.Parameters.AddWithValue("@Tackling", Tacklingcomments);
                Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
                Command.ExecuteNonQuery();

            }
            MessageBox.Show("Data Was Added Accordingly");
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
    // end of passing section for both juniors and seniors

    public static void SeniorStandardSpin1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardSpin2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardSpin3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardSpin4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardSpin5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    // end of spin skill section for senior and begining for junior

    public static void JuniorStandardSpin1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardSpin2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardSpin3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardSpin4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardSpin5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Spin Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    // end of entire spin section
    public static void JuniorStandardPop1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardPop2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardPop3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardPop4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void JuniorStandardPop5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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



    public static void SeniorStandardPop1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardPop2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardPop3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardPop4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorStandardPop5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Pop Standard";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void SeniorTacklingFront1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingFront2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingFront3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingFront4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingFront5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorTacklingFront1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingFront2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingFront3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingFront4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingFront5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Front Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void SeniorTacklingRear1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingRear2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingRear3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingRear4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingRear5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorTacklingRear1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingRear2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingRear3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingRear4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingRear5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Rear Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingSide1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingSide2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingSide3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingSide4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingSide5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorTacklingSide1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingSide2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingSide3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingSide4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingSide5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Side Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingScrabble1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingScrabble2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingScrabble3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingScrabble4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorTacklingScrabble5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorTacklingScrabble1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingScrabble2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingScrabble3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingScrabble4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorTacklingScrabble5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Scrabble Tackling";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    public static void SeniorKickingDrop1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingDrop2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingDrop3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingDrop4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingDrop5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorKickingDrop1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingDrop2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingDrop3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingDrop4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingDrop5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Drop Kicking";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    // punt

    public static void SeniorKickingPunt1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingPunt2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingPunt3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingPunt4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingPunt5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorKickingPunt1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingPunt2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingPunt3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingPunt4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingPunt5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Punt Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    // grubber

    public static void SeniorKickingGrubber1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGrubber2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGrubber3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGrubber4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGrubber5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorKickingGrubber1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGrubber2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGrubber3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGrubber4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGrubber5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Grubber Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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
    // goal kicking and last of the skills section 

    public static void SeniorKickingGoal1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGoal2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGoal3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGoal4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorKickingGoal5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, Skill_Name,Skill_Proficiency) Select SPlayer_ID, SPlayer_FirstName,SPlayer_LastName, @Skill_Name, @Skill_Proficiency  From SeniorPlayers WHERE SPlayer_ID = @SPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@SPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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


    public static void JuniorKickingGoal1(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 1;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGoal2(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 2;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGoal3(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 3;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGoal4(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 4;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void JuniorKickingGoal5(string SquadID22)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string query = "INSERT INTO  SkillLevels  (JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, Skill_Name,Skill_Proficiency) Select JPlayer_ID, JPlayer_FirstName,JPlayer_LastName, @Skill_Name, @Skill_Proficiency  From JuniorPlayers WHERE JPlayer_ID = @JPlayerID;";// the string query that works perfectly...
        int SkillProficiency = 5;
        string SkillName = "Goal Kick";
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Skill_Proficiency", SkillProficiency);
            Command.Parameters.AddWithValue("@Skill_Name", SkillName);
            Command.Parameters.AddWithValue("@JPlayerID", SquadID22);
            Command.ExecuteNonQuery();

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

    public static void SeniorSkillsViewer(string playerskillID, DataGrid SkillsDT)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string Query = "SELECT SPlayer_ID, Skill_Name, Skill_Proficiency, SPlayer_FirstName, SPlayer_LastName,Passing, Kicking, Tackling FROM SkillLevels WHERE SPlayer_ID = @SPlayerID;";
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(Query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@SPlayerID", playerskillID);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SkillsDT.ItemsSource = dt.DefaultView;

        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }

        finally { Connection.Close(); }

    }
    public static void JuniorSkillsViewer(string playerskillID, DataGrid SkillsDT)
    {
        using var Connection = new SQLiteConnection(ConnectionString);
        string Query = "SELECT JPlayer_ID, Skill_Name, Skill_Proficiency, JPlayer_FirstName, JPlayer_LastName,Passing, Kicking, Tackling FROM SkillLevels WHERE JPlayer_ID = @JPlayerID;";
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(Query, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@JPlayerID", playerskillID);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SkillsDT.ItemsSource = dt.DefaultView;

        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }

        finally { Connection.Close(); }

    }
    public static void JuniorSkillCleaner(string playerskillID)
    {
        string Query = "DELETE FROM SkillLevels WHERE JPlayer_ID = @JPlayerID";

        using var Connection = new SQLiteConnection(ConnectionString);
        {
          
            try
            {
                Connection.Open();
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@JPlayerID", playerskillID);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Past records Cleared out Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }
       
    }
    public static void SeniorSkillCleaner(string playerskillID)
    {
        string Query = "DELETE FROM SkillLevels WHERE SPlayer_ID = @SPlayerID";

        using var Connection = new SQLiteConnection(ConnectionString);
        {

            try
            {
                Connection.Open();
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@SPlayerID", playerskillID);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Past records Cleared out Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

    }
}

// make one of the statments update while the rest are inserts in order to create a new section
// i have repeated myself too many times in this project i need to learn polymorphism... 
// this whole class's funt=ctionality is to save the input from the user based on what the skills are and pass it to the database 
// some areas of the code will be used to display such data to the datagrids to the players and their card, this is justso that players are able to actively receive their own feed back
// using try statments for bud detection and managemnt, we try to establish and open the connection with the databse they we pass the string query and change its datatype to text which is compatible with sqlite, then we display the data we selected using the string query to the data grid and we pass that same datagrid back to the other class which os responsible for displaying it all.