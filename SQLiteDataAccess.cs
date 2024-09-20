using SimplyRugby2._0;
using System.Data;
using System.Data.SQLite;
using System.Drawing.Design;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using MessageBox = System.Windows.Forms.MessageBox;
// this class will be used to pass down most of the functions to the squads section the login section and dashboards.
public static class SQLiteDataAccess
{
    private static string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";//setting up the string conections data source using the databse created at the begining when the application is ran using database helper class
    public static void InsertIntoSeniorPlayers(string PlayerID, string PlayerFirstName, string PlayerLastName, string PlayerEmail, string PlayerAddress, string PlayerNumber, string PlayerDOB)
    {
        string query = "INSERT INTO SeniorPlayers ( SPlayer_ID,SPlayer_FirstName, SPlayer_LastName, SPlayer_Email,SPlayer_Address, SPlayer_Number, DOB) VALUES (@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName,@SPlayer_Email,@SPlayer_Address,@SPlayer_Number,@DOB);" + "INSERT INTO SkillLevels( SPlayer_ID, SPlayer_FirstName,SPlayer_LastName) VALUES (@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName);" + "INSERT INTO Login (SPlayer_ID) Values(@SPlayer_ID);";

        // this section is to add a senior player to the tables in my database using a string query and sqlite libraries, or tools/methods avialable to sqlite.
        // creating a var which self identifies if its a string or int based  on context of code..
        //creating a new instance of sqliteconnection named connection and passing the connection string to it, in order to show it what databse we are targeting
        using var Connection = new SQLiteConnection(ConnectionString);
        try//using a try statment for error managment 
        {
            Connection.Open();// trying to establish and open the connection if this fails the catch message will display the error to the user informing us of why it failed 
            using (var Command = new SQLiteCommand(query, Connection))// creating a new instance of sqlite command calling it command and passing the string query and connection to it to tell it what will be done using the query and where later and what will effect the database
            {
                Command.CommandType = CommandType.Text;//converting the sql command type to text meaning every item taken out of the application from the user will be converted to text and all inputs will be converted to text unless their data type is defined as an int in the databse
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerID);// player id is a text box which we will use to get the input from the user to then place into the database the users ids will be inputted manually so there is no auto increment function in the database helper
                Command.Parameters.AddWithValue("@SPlayer_FirstName", PlayerFirstName);// grabbing the first name from the user and inputting it into the database
                Command.Parameters.AddWithValue("@SPlayer_LastName", PlayerLastName);// same with the lastname, email, number, address and date of birth.
                Command.Parameters.AddWithValue("@SPlayer_Email", PlayerEmail);
                Command.Parameters.AddWithValue("@SPlayer_Address", PlayerAddress);
                Command.Parameters.AddWithValue("@SPlayer_Number", PlayerNumber);
                Command.Parameters.AddWithValue("@DOB", PlayerDOB);
                Command.ExecuteNonQuery();// You can use the ExecuteNonQuery to perform catalog operations (for example, querying the structure of a database or creating database objects such as tables), or to change the data in a database without using a DataSet by executing UPDATE, INSERT, or DELETE statements.
                //https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.executenonquery?view=dotnet-plat-ext-5.0&viewFallbackFrom=dotnet-plat-ext-6.0
            }


            MessageBox.Show("Senior Player Added Successfully. ");// sending in a message box to inform the user that their player was added successfully
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);// sending the error message incase an error pops up
        }
        finally
        {
            Connection.Close();//closing the database connection to save resources
        }
    }
    public static void InsertIntoEmergencyContactsCoaches(string ContactID, string ContactFirstName, string ContactLastName, string ContactEmail, string ContactAddress, string ContactNumber, string ContactDOB, string MemberID)//need to change the variable's name, For both coaches and staff
    {
        string query = "insert into EmergencyContacts (Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, Coaches_ID) Values (@Contact_ID,@Contact_FirstName,@Contact_LastName,@Contact_Email,@Contact_Address,@Contact_Number,@Contact_DOB,@Coaches_ID)";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one
            using (var Command = new SQLiteCommand(query, Connection))
            {

                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Contact_ID", ContactID);
                Command.Parameters.AddWithValue("@Contact_FirstName", ContactFirstName);
                Command.Parameters.AddWithValue("@Contact_LastName", ContactLastName);
                Command.Parameters.AddWithValue("@Contact_Email", ContactEmail);
                Command.Parameters.AddWithValue("@Contact_Address", ContactAddress);
                Command.Parameters.AddWithValue("@Contact_Number", ContactNumber);
                Command.Parameters.AddWithValue("@Contact_DOB", ContactDOB);
                Command.Parameters.AddWithValue("@Coaches_ID", MemberID);//newest addition is the insert into IDs to ensure the conneection between tables  
                Command.ExecuteNonQuery();
            }
            MessageBox.Show("Added into emergency contacts successfully. ");
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
    public static void InsertIntoEmergencyContactsSeniors(string ContactID, string ContactFirstName, string ContactLastName, string ContactEmail, string ContactAddress, string ContactNumber, string ContactDOB, string PlayerID)// need to add an insert playerID section at the end of the contacts here just to ensure that they are linked with the players tables
    {
        string query = "insert into EmergencyContacts (Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, SPlayer_ID) Values (@Contact_ID,@Contact_FirstName,@Contact_LastName,@Contact_Email,@Contact_Address,@Contact_Number,@Contact_DOB,@SPlayer_ID)";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one
            using (var Command = new SQLiteCommand(query, Connection))
            {

                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Contact_ID", ContactID);
                Command.Parameters.AddWithValue("@Contact_FirstName", ContactFirstName);
                Command.Parameters.AddWithValue("@Contact_LastName", ContactLastName);
                Command.Parameters.AddWithValue("@Contact_Email", ContactEmail);
                Command.Parameters.AddWithValue("@Contact_Address", ContactAddress);
                Command.Parameters.AddWithValue("@Contact_Number", ContactNumber);
                Command.Parameters.AddWithValue("@Contact_DOB", ContactDOB);
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerID);//newest addition is the insert into IDs to ensure the conneection between tables
                Command.ExecuteNonQuery();
            }
            MessageBox.Show("Added into emergency contacts successfully. ");
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
    public static void InsertIntoEmergencyContactsJuniors(string ContactID, string ContactFirstName, string ContactLastName, string ContactEmail, string ContactAddress, string ContactNumber, string ContactDOB, string PlayerID)// need to add an insert playerID section at the end of the contacts here just to ensure that they are linked with the players tables
    {
        string query = "insert into EmergencyContacts (Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, JPlayer_ID) Values (@Contact_ID,@Contact_FirstName,@Contact_LastName,@Contact_Email,@Contact_Address,@Contact_Number,@Contact_DOB,@JPlayer_ID)";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {

                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Contact_ID", ContactID);
                Command.Parameters.AddWithValue("@Contact_FirstName", ContactFirstName);
                Command.Parameters.AddWithValue("@Contact_LastName", ContactLastName);
                Command.Parameters.AddWithValue("@Contact_Email", ContactEmail);
                Command.Parameters.AddWithValue("@Contact_Address", ContactAddress);
                Command.Parameters.AddWithValue("@Contact_Number", ContactNumber);
                Command.Parameters.AddWithValue("@Contact_DOB", ContactDOB);
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerID);//newest addition is the insert into IDs to ensure the conneection between tables
                Command.ExecuteNonQuery();
            }
            MessageBox.Show("Added into emergency contacts successfully. ");
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
    public static void InsertIntoEmergencyContactsStaff(string ContactID, string ContactFirstName, string ContactLastName, string ContactEmail, string ContactAddress, string ContactNumber, string ContactDOB, string MemberID)//change the name here agaian...
    {
        string query = "insert into EmergencyContacts (Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, Staff_ID) Values (@Contact_ID,@Contact_FirstName,@Contact_LastName,@Contact_Email,@Contact_Address,@Contact_Number,@Contact_DOB,@Staff_ID)";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Contact_ID", ContactID);
                Command.Parameters.AddWithValue("@Contact_FirstName", ContactFirstName);
                Command.Parameters.AddWithValue("@Contact_LastName", ContactLastName);
                Command.Parameters.AddWithValue("@Contact_Email", ContactEmail);
                Command.Parameters.AddWithValue("@Contact_Address", ContactAddress);
                Command.Parameters.AddWithValue("@Contact_Number", ContactNumber);
                Command.Parameters.AddWithValue("@Contact_DOB", ContactDOB);
                Command.Parameters.AddWithValue("@Staff_ID", MemberID);//newest addition is the insert into IDs to ensure the conneection between tables remember to change the box name.
                Command.ExecuteNonQuery();
            }
            MessageBox.Show("Added into emergency contacts successfully. ");
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
    public static void InsertIntoJuniorPlayers(string PlayerID, string PlayerFirstName, string PlayerLastName, string PlayerEmail, string PlayerAddress, string PlayerNumber, string PlayerDOB)
    {
        string query = " insert into  JuniorPlayers ( JPlayer_ID, JPlayer_FirstName, JPlayer_LastName, JPlayer_Email, JPlayer_Address, JPlayer_Number, DOB) Values (@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName,@JPlayer_Email,@JPlayer_Address,@JPlayer_Number,@DOB);" + "INSERT INTO SkillLevels( JPlayer_ID, JPlayer_FirstName,JPlayer_LastName) VALUES (@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName);" + "INSERT INTO Login (JPlayer_ID) Values (@JPlayer_ID);";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one
            Connection.Open();
            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerID);
                Command.Parameters.AddWithValue("@JPlayer_FirstName", PlayerFirstName);
                Command.Parameters.AddWithValue("@JPlayer_LastName", PlayerLastName);
                Command.Parameters.AddWithValue("@JPlayer_Email", PlayerEmail);
                Command.Parameters.AddWithValue("@JPlayer_Address", PlayerAddress);
                Command.Parameters.AddWithValue("@JPlayer_Number", PlayerNumber);
                Command.Parameters.AddWithValue("@DOB", PlayerDOB);
                Command.ExecuteNonQuery();
            }

            MessageBox.Show("Junior Player Added Successfully. ");
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

    public static void InsertIntoCoaches(string MemberID, string MemberFirstName, string MemberLastName, string MemberEmail, string MemberAddress, string MemberNumber, string MemberDOB)//will also need an insert here to link the contacts and an insert with staff seniors and juniors as well...
    {
        string query = " insert into  Coaches (Coaches_ID, Coaches_FirstName, Coaches_LastName, Coaches_Email,Coaches_Address, Coaches_Number, DOB) Values (@Coaches_ID, @Coaches_FirstName, @Coaches_LastName,@Coaches_Email,@Coaches_Address,@Coaches_Number,@DOB);" + "INSERT INTO Login (Coaches_ID) Values (@Coaches_ID);";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one
            Connection.Open();

            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Coaches_ID", MemberID);
                Command.Parameters.AddWithValue("@Coaches_FirstName", MemberFirstName);
                Command.Parameters.AddWithValue("@Coaches_LastName", MemberLastName);
                Command.Parameters.AddWithValue("@Coaches_Email", MemberEmail);
                Command.Parameters.AddWithValue("@Coaches_Address", MemberAddress);
                Command.Parameters.AddWithValue("@Coaches_Number", MemberNumber);
                Command.Parameters.AddWithValue("@DOB", MemberDOB);
                Command.ExecuteNonQuery();
            }

            MessageBox.Show("Coach Added Successfully.");
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




    public static void InsertIntoStaff(string MemberID, string MemberFirstName, string MemberLastName, string MemberEmail, string MemberAddress, string MemberNumber, string MemberDOB)
    {
        string query = " insert into  Staff (Staff_ID, Staff_FirstName, Staff_LastName, Staff_Email,Staff_Address, Staff_Number, DOB) Values (@Staff_ID, @Staff_FirstName, @Staff_LastName,@Staff_Email,@Staff_Address,@Staff_Number,@DOB);" + "INSERT INTO Login (Staff_ID) Values (@Staff_ID);";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one
            Connection.Open();

            using (var Command = new SQLiteCommand(query, Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Staff_ID", MemberID);
                Command.Parameters.AddWithValue("@Staff_FirstName", MemberFirstName);
                Command.Parameters.AddWithValue("@Staff_LastName", MemberLastName);
                Command.Parameters.AddWithValue("@Staff_Email", MemberEmail);
                Command.Parameters.AddWithValue("@Staff_Address", MemberAddress);
                Command.Parameters.AddWithValue("@Staff_Number", MemberNumber);
                Command.Parameters.AddWithValue("@DOB", MemberDOB);
                Command.ExecuteNonQuery();
            }

            MessageBox.Show("Staff Member Added Successfully.");
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

    // squads 

    public static void AddSeniorToSquadA(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where SPlayer_ID=@SPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team A";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
              

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                    
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@SPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@SPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Senior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }

    public static void AddJuniorToSquadA(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where JPlayer_ID=@JPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team A";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
         

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                      
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@JPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@JPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Junior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddSeniorToSquadB(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where SPlayer_ID=@SPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team B";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
         

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                     
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@SPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@SPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Senior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddJuniorToSquadB(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where JPlayer_ID=@JPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team B";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
            

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                  
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@JPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@JPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Junior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddSeniorToSquadC(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where SPlayer_ID=@SPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team C";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
       

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                      
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@SPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@SPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Senior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddJuniorToSquadC(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where JPlayer_ID=@JPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team C";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
        

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                       
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@JPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@JPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Junior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddSeniorToSquadD(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where SPlayer_ID=@SPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team D";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
           

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@SPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@SPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Senior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddJuniorToSquadD(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where JPlayer_ID=@JPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team D";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
              

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@JPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@JPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Junior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }

    public static void AddSeniorToSquadE(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@SPlayer_ID, @SPlayer_FirstName, @SPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where SPlayer_ID=@SPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team E";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
             

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                    
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@SPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@SPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@SPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Senior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch
        {
            Connection.Close();
        }
    }


    public static void AddJuniorToSquadE(string PlayerId12, string PlayerFirstname22, string PlayerLastname22, string newSquadID, string Commentssection)
    {
        string query = @"INSERT INTO Squads (Squad_ID, Squad_Name, JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,Comments) VALUES (@Squad_ID,@Squad_Name,@JPlayer_ID, @JPlayer_FirstName, @JPlayer_LastName,@Comments)";
        string query2 = "select Count(*) from Login where JPlayer_ID=@JPlayer_ID";// first query is to add to the squad second query is to check if user exists if not then it will give an error message.
        string SquadName = "Team E";
        using var Connection = new SQLiteConnection(ConnectionString);

        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query2, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);


                int count = Convert.ToInt32(Command.ExecuteScalar());
          

                if (count == 1)// checks if conditiotn is fullfilled
                {
                    try
                    {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one

                  
                        using (var Command2 = new SQLiteCommand(query, Connection))
                        {
                            Command2.CommandType = CommandType.Text;
                            Command2.Parameters.AddWithValue("@JPlayer_ID", PlayerId12);
                            Command2.Parameters.AddWithValue("@JPlayer_FirstName", PlayerFirstname22);
                            Command2.Parameters.AddWithValue("@JPlayer_LastName", PlayerLastname22);
                            Command2.Parameters.AddWithValue("@Squad_ID", newSquadID);
                            Command2.Parameters.AddWithValue("@Squad_Name", SquadName);
                            Command2.Parameters.AddWithValue("@Comments", Commentssection);
                            Command2.ExecuteNonQuery();

                        }



                        MessageBox.Show(" Junior Player Added to Squad A Successfully");
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
                else
                {
                    MessageBox.Show("No such user exists check Player ID and try again");
                }



            }
        }
        catch// always closing the connection at the end to ensure that resources are being used in accourdance to what is desired and nothing more.
        {
            Connection.Close();
        }
    }

    // below will be the remove from squads section.
    // this will be the section to clear a squad off of all players
    public static void ClearSquadA()
    {
        string query = @"DELETE FROM Squads WHERE Squad_Name = @Squad_Name";
        string SquadName = "Team A";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {// establishes the connection and opens it then closes it at the end to save reosurces while also being inside a try catch finally statment for bug detection and managment, the values below or statments below get the input from the user and add it to the table, and then sends out a confirmation message to inform the user of the most recent changes, the values are added by passing in the names and data types from the other class or wpf page into this one does this while also deleting the players to the pre existing squads based on whats inside the textbox.
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove all members from this Squad", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Connection.Open();
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Squad Cleared out successfully");

            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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
    public static void ClearSquadB()
    {// clears out the entire squad meaning no players will be in it useful for when the coaches decide to set up a new squad.
        string query = @"DELETE FROM Squads WHERE Squad_Name = @Squad_Name";
        string SquadName = "Team  B";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove all members from this Squad", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {// confirmation message box used to warn the user of the consequenses.
                Connection.Open();
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Squad Cleared out successfully");

            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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
    public static void ClearSquadC()
    {
        string query = @"DELETE FROM Squads WHERE Squad_Name = @Squad_Name";
        string SquadName = "Team C";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove all members from this Squad", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Connection.Open();
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Squad Cleared out successfully");

            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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
    public static void ClearSquadD()
    {
        string query = @"DELETE FROM Squads WHERE Squad_Name = @Squad_Name";
        string SquadName = "Team D";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove all members from this Squad", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Connection.Open();
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Squad Cleared out successfully");

            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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
    public static void ClearSquadE()
    {
        string query = @"DELETE FROM Squads WHERE Squad_Name = @Squad_Name";
        string SquadName = "Team E";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove all members from this Squad", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Connection.Open();
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                    Command.ExecuteNonQuery();
                }
                MessageBox.Show("Squad Cleared out successfully");

            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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
    // delete from squad based on ID
    public static void DeleteFromSquadOnIDSPlayer(string PlayerdeleteID)
    {
        string query = @"DELETE FROM Squads WHERE SPlayer_ID = @SPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove this members from Which ever Squad they are in Squad", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Connection.Open();
                using var Command = new SQLiteCommand(query, Connection);
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", Convert.ToInt32(PlayerdeleteID));
                Command.ExecuteNonQuery();

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected > 0)
                {
                    MessageBox.Show("Player With this ID not found or doesnt exist");

                }
                else
                {
                    MessageBox.Show("Player Removed from squad Successfully");
                }

            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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
    public static void DeleteFromSquadOnIDJPlayer(string PlayerdeleteID)
    {
        string query = @"DELETE FROM Squads WHERE JPlayer_ID = @JPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("are you sure you want to remove this members from which ever squad they are in.", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Connection.Open();
                using var Command = new SQLiteCommand(query, Connection);
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", Convert.ToInt32(PlayerdeleteID));
                Command.ExecuteNonQuery();

                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected > 0)
                {
                    MessageBox.Show("Player Removed from squad Successfully");

                }
                else
                {
                    MessageBox.Show("Player With this ID not found or doesnt exist");

                }
            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("No changes were made");
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

    public static void ChangeCoachesPassword(string CoachUsernametxtbox, string CoachPasstxtbox)
    {// uses the update query to change the coaches password without any confirmation
        // applying confirmation could be if user password exists then update set passwords, from login, if user password doesnt exist then send a message saying the password doesnt exist measning we cant change it unless you go to the secretary /just an extra addable feature to ensure the saftey of information

        string query = "Update Login Set Passwords = @Passwords where Coaches_ID = @Coaches_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {

            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Coaches_ID", CoachUsernametxtbox);
                Command.Parameters.AddWithValue("@Passwords", CoachPasstxtbox);
                //Command.ExecuteNonQuery();
                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected > 0)
                {// checks if any rows in the databse is effected if none are then it says user not found or password not changed however if 1 is then it confirms the password change.
                    MessageBox.Show("Password Changed Successfully");

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


    public static void ChangeStaffPassword(string CoachUsernametxtbox, string CoachPasstxtbox)
    {

        string query = "Update Login Set Passwords = @Passwords WHERE Staff_ID =@Staff_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Staff_ID", CoachUsernametxtbox);
                Command.Parameters.AddWithValue("@Passwords", CoachPasstxtbox);
                Command.ExecuteNonQuery();
                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected > 0)
                {
                    MessageBox.Show("User With this ID not found or doesnt exist");
                    // checks if any rows in the databse is effected if none are then it says user not found or password not changed however if 1 is then it confirms the password change.

                }
                else
                {
                    MessageBox.Show("Password Changed Successfully");
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

    public static void DisplaySquadA(DataGrid SquadDataGrid)
    {

        string query = "SELECT Squad_ID, Squad_Name,JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments FROM Squads Where Squad_Name=@Squad_Name";
        string SquadName = "Team A";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;//grabs the data grid from the other class and uses it to display data by creating an instance of it, and setting it as the items source or the source of the data.
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

    public static void DisplaySquadB(DataGrid SquadDataGrid)
    {

        string query = "SELECT Squad_ID, Squad_Name,JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments FROM Squads Where Squad_Name=@Squad_Name";
        string SquadName = "Team B";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;
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

    public static void DisplaySquadC(DataGrid SquadDataGrid)
    {

        string query = "SELECT Squad_ID, Squad_Name,JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments FROM Squads Where Squad_Name=@Squad_Name";
        string SquadName = "Team C";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;
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
    public static void DisplaySquadD(DataGrid SquadDataGrid)
    {

        string query = "SELECT Squad_ID, Squad_Name,JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments FROM Squads Where Squad_Name=@Squad_Name";
        string SquadName = "Team D";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;
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
    public static void DisplaySquadE(DataGrid SquadDataGrid)
    {

        string query = "SELECT Squad_ID, Squad_Name,JPlayer_ID, JPlayer_FirstName, JPlayer_LastName,SPlayer_ID, SPlayer_FirstName, SPlayer_LastName,Comments FROM Squads Where Squad_Name=@Squad_Name";
        string SquadName = "Team E";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Squad_Name", SquadName);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;
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


    public static void SearchBySuqadID(DataGrid SquadDataGrid, string SquadID)
    {
        string query = @"SELECT SP.SPlayer_FirstName,SP.SPlayer_LastName,SP.SPlayer_Email,SP.SPlayer_Number,SP.DOB,JP.JPLayer_FirstName,JP.JPLayer_LastName,JP.JPlayer_Email,JP.JPlayer_Number,JP.DOB,S.Squad_Name FROM Squads S LEFT JOIN SeniorPlayers SP ON SP.SPlayer_ID = S.SPlayer_ID LEFT JOIN JuniorPlayers JP ON JP.JPlayer_ID = S.JPlayer_ID WHERE S.Squad_ID=@Squad_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Squad_ID", SquadID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;
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

    public static void SearchByPlayerID(DataGrid SquadDataGrid, string SquadID)
    {
        string query = "SELECT SPlayer_FirstName, SPlayer_LastName, SPlayer_Email, SPlayer_Address, SPlayer_Number, DOB FROM SeniorPlayers WHERE SPlayer_ID=@SPlayer_ID UNION ALL SELECT JPlayer_FirstName, JPlayer_LastName , JPlayer_Email, JPlayer_Address, JPlayer_Number, DOB FROM JuniorPlayers WHERE JPlayer_ID=@JPlayer_ID";// used key word union all to unite the database tables other wise itd show an error

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", SquadID);
                Command.Parameters.AddWithValue("@SPlayer_ID", SquadID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SquadDataGrid.ItemsSource = dt.DefaultView;
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


    // i have decided to make 2 functions that do the sme thing because i didnt want to go back and make the names of the items in my desing similar or eve the same just to avoid it being annoying later...

    public static void SearchbyID2(string searchtxtbox, DataGrid dataGrid)
    {
        string query = "SELECT SPlayer_FirstName, SPlayer_LastName, SPlayer_Email, SPlayer_Address, SPlayer_Number, DOB FROM SeniorPlayers WHERE SPlayer_ID=@SPlayer_ID UNION ALL SELECT JPlayer_FirstName, JPlayer_LastName , JPlayer_Email, JPlayer_Address, JPlayer_Number, DOB FROM JuniorPlayers WHERE JPlayer_ID=@JPlayer_ID";// used key word union all to unite the database tables other wise itd show an error

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", searchtxtbox);
                Command.Parameters.AddWithValue("@SPlayer_ID", searchtxtbox);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
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

    public static void DeletePlayers(string searchtxtbox)
    {
        string query = "DELETE From SkillLevels where SPlayer_ID = @SPlayer_ID;" + "DELETE From SkillLevels where JPlayer_ID = @JPlayer_ID;" + "DELETE From Squads where SPlayer_ID = @SPlayer_ID;" + "DELETE From Squads where JPlayer_ID = @JPlayer_ID;" + "DELETE From Login where SPlayer_ID = @SPlayer_ID; " + "DELETE From EmergencyContacts where SPlayer_ID = @SPlayer_ID; " + "DELETE From SeniorPlayers WHERE SPlayer_ID=@SPlayer_ID; " + " DELETE From Login where JPlayer_ID = @JPlayer_ID; " + " DELETE From EmergencyContacts where JPlayer_ID = @JPlayer_ID;  " + " DELETE From JuniorPlayers WHERE JPlayer_ID=@JPlayer_ID;";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {

                Command.CommandType = CommandType.Text;// go back and add this to everything its vital idk why i deleted it OMD :(
                Command.Parameters.AddWithValue("@JPlayer_ID", searchtxtbox);
                Command.Parameters.AddWithValue("@SPlayer_ID", searchtxtbox);
                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 0)
                {
                    MessageBox.Show("No Players deleted");
                }
                else
                {
                    MessageBox.Show("Player detelted successfuly and so did their records");
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


    public static void SearchStaffOrCoaches(string StaffIDtxtbox, DataGrid CoachDataGrid)
    {
        string query = "SELECT Staff_FirstName, Staff_LastName, Staff_Email, Staff_Address, Staff_Number, DOB FROM Staff WHERE Staff_ID=@Staff_ID UNION ALL SELECT Coaches_FirstName, Coaches_LastName , Coaches_Email, Coaches_Address, Coaches_Number, DOB FROM Coaches WHERE Coaches_ID=@Coaches_ID";// used key word union all to unite the database tables other wise itd show an error
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {

                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Coaches_ID", StaffIDtxtbox);
                Command.Parameters.AddWithValue("@Staff_ID", StaffIDtxtbox);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CoachDataGrid.ItemsSource = dt.DefaultView;
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

    public static void DeleteFromCoachesOrStaff(string StaffIDtxtbox)
    {
        string query = " Delete From Login where Staff_ID = @Staff_ID; Delete From EmergencyContacts where Staff_ID = @Staff_ID; Delete From Staff WHERE Staff_ID=@Staff_ID Delete From Login where Coaches_ID = @Coaches_ID; Delete From EmergencyContacts where Coaches_ID = @Coaches_ID; Delete From Coaches WHERE Coaches_ID=@Coaches_ID";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Coaches_ID", StaffIDtxtbox);
                Command.Parameters.AddWithValue("@Staff_ID", StaffIDtxtbox);
                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 0)
                {
                    MessageBox.Show("No Coaches or Staff Members deleted");
                }
                else
                {
                    MessageBox.Show("Coaches or Staff Members detelted successfuly and so did their records");
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
    public static void UpdateSeniorLogin(string UserID, string UserPassword)
    {
        string query = "Update Login SET Passwords = @Passwords where SPlayer_ID =@SPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SPlayer_ID", UserID);
                Command.Parameters.AddWithValue("@Passwords", UserPassword);
                Command.ExecuteNonQuery();
                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 0)
                {
                    MessageBox.Show("No Passwords changed.");
                }
                else
                {
                    MessageBox.Show("SeniorPlayers Password Changed Succesfully");
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

    public static void UpdateJuniorLogin(string UserID, string UserPassword)
    {
        string query = "Update Login SET Passwords =@Passwords where JPlayer_ID =@JPlayer_ID";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", UserID);
                Command.Parameters.AddWithValue("@Passwords", UserPassword);
                Command.ExecuteNonQuery();
                int rowseffected = Command.ExecuteNonQuery();
                if (rowseffected == 0)
                {
                    MessageBox.Show("No Passwords changed.");
                }
                else
                {
                    MessageBox.Show("JuniorPlayers Password Changed Succesfully");
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
    public static void SearchContacts(string ContactsSearch, DataGrid DataGrid)
    {
        string query = @"
SELECT SPlayer_FirstName, SPlayer_LastName, SPlayer_Number, SPlayer_Email, SPlayer_Address, Contact_FirstName, Contact_LastName, Contact_Number, Contact_Email, Contact_Address 
FROM SeniorPlayers
INNER JOIN EmergencyContacts  ON SeniorPlayers.SPlayer_ID = EmergencyContacts.SPlayer_ID
WHERE SeniorPlayers.SPlayer_ID = @Player_ID
UNION ALL
SELECT JPlayer_FirstName, JPlayer_LastName, JPlayer_Number, JPlayer_Email, JPlayer_Address, Contact_FirstName, Contact_LastName, Contact_Number, Contact_Email, Contact_Address 
FROM JuniorPlayers 
INNER JOIN EmergencyContacts  ON JuniorPlayers.JPlayer_ID = EmergencyContacts.JPlayer_ID
WHERE JuniorPlayers.JPlayer_ID = @Player_ID";// uses union and inner join and changes the names of splayer and jplayer combining them into one 

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Player_ID", ContactsSearch);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.ItemsSource = dt.DefaultView;
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
    // so far so good still need to add the interface to the players sections the players skill section for the coaches, the mailing list, and then sort out the database by allowing some items to be null.... 
    // could have probably made those in the same window...
    public static void SearchStaffContacts(string searchtxtbox, DataGrid ContactsDataGrid)
    {
        string query = @"
SELECT Coaches_FirstName, Coaches_LastName, Coaches_Number, Coaches_Email, Coaches_Address, Contact_FirstName, Contact_LastName, Contact_Number, Contact_Email, Contact_Address 
FROM Coaches
INNER JOIN EmergencyContacts  ON Coaches.Coaches_ID = EmergencyContacts.Coaches_ID
WHERE Coaches.Coaches_ID = @Contacts_ID
UNION ALL
SELECT STaff_FirstName, Staff_LastName, Staff_Number, Staff_Email, Staff_Address, Contact_FirstName, Contact_LastName, Contact_Number, Contact_Email, Contact_Address 
FROM Staff 
INNER JOIN EmergencyContacts  ON Staff.Staff_ID = EmergencyContacts.Staff_ID
WHERE Staff.Staff_ID = @Contacts_ID";// uses union and inner join and changes the names of splayer and jplayer combining them into one, writing this one is was a headache there has to be a better way  


        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Contacts_ID", searchtxtbox);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);//making the data adapeter instance fill the datatable..
                ContactsDataGrid.ItemsSource = dt.DefaultView;
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

    public static void SearchTabeForSJ(string searchtxtbox2, DataGrid dataGrid)
    {
        string query = "SELECT SPlayer_FirstName, SPlayer_LastName, SPlayer_Email, SPlayer_Address, SPlayer_Number, DOB FROM SeniorPlayers WHERE SPlayer_ID=@SPlayer_ID UNION ALL SELECT JPlayer_FirstName, JPlayer_LastName , JPlayer_Email, JPlayer_Address, JPlayer_Number, DOB FROM JuniorPlayers WHERE JPlayer_ID=@JPlayer_ID";// used key word union all to unite the database tables other wise itd show an error
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", searchtxtbox2);
                Command.Parameters.AddWithValue("@SPlayer_ID", searchtxtbox2);
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
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
    public static void ViewAllJunior(DataGrid dataGrid)
    {
        string query = "SELECT * From JuniorPlayers";// selects all memebrs in the junior players table and displays it to the secretary, 

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();// opens up the connection between the db and the application, inside a try catch finally, to help with bug detection, managment and organization.
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
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

    public static void ViewAllSenior(DataGrid dataGrid)
    {
        string query = "SELECT * From SeniorPlayers";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
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
    public static void ViewAllCoaches(DataGrid CoachDataGrid)
    {
        string query = "SELECT * From Coaches";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CoachDataGrid.ItemsSource = dt.DefaultView;
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

    public static void ViewAllStaff(DataGrid CoachDataGrid)
    {
        string query = "SELECT * From Staff";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            var Command = new SQLiteCommand(query, Connection);
            {
                Command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CoachDataGrid.ItemsSource = dt.DefaultView;
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

    public static void SearchV8(string Searchalltxt, DataGrid CoachDataGrid)
    {
        string query = "SELECT Staff_FirstName, Staff_LastName, Staff_Email, Staff_Address, Staff_Number, DOB FROM Staff WHERE Staff_ID=@Staff_ID UNION ALL SELECT Coaches_FirstName, Coaches_LastName , Coaches_Email, Coaches_Address, Coaches_Number, DOB FROM Coaches WHERE Coaches_ID=@Coaches_ID";// used key word union all to unite the database tables other wise itd show an error
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection)
            {// looks for staff memmbers and their information based on id which is provided by the user or secretary a login verification window should be set up here to protect users and their data. 
                CommandType = CommandType.Text
            };
            Command.Parameters.AddWithValue("@Coaches_ID", Searchalltxt);
            Command.Parameters.AddWithValue("@Staff_ID", Searchalltxt);
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CoachDataGrid.ItemsSource = dt.DefaultView;
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
    public static void ExportStaffMailingList()
    {
        string OutPutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MailingList.txt");
        using StreamWriter sw = new StreamWriter(OutPutPath, true);//if its true it will append to the list otherwise it will overwrite it.
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            string query = "Select Staff_FirstName, Staff_LastName, Staff_Email From Staff;";
            using var Command = new SQLiteCommand(query, Connection);

            using var Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string FirstName = Reader.GetString(0);
                string LastName = Reader.GetString(1);
                string Email = Reader.GetString(2);
                string Definer = "\nAll Staff Members\n";
                string Ender = "\nEnd Of Staff Mailing List\n";
                string line = Definer + $"{FirstName},\n{LastName},\n{Email}" + Ender;// new stuff added add it to the rest after much testing just to keep the format tidy
                sw.WriteLine(line);
            }
            MessageBox.Show("Mailing List Exported To: \n" + OutPutPath);
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
    public static void ExportCoachesMailingList()
    {
        String OutPutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MailingList.txt");
        using StreamWriter sw = new StreamWriter(OutPutPath, true);
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            string query = "Select Coaches_FirstName, Coaches_LastName, Coaches_Email From Coaches;";
            using var Command = new SQLiteCommand(query, Connection);

            using var Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string FirstName = Reader.GetString(0);
                string LastName = Reader.GetString(1);
                string Email = Reader.GetString(2);
                string Definer = "\nAll Coaches\n";
                string Ender = "\nEnd Of Coaches Mailing List\n";
                string line = Definer + $"{FirstName},\n{LastName},\n{Email}" + Ender;// new stuff added add it to the rest after much testing
                sw.WriteLine(line);
            }
            MessageBox.Show("Mailing List Exported To: \n" + OutPutPath);
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
    public static void ExportSeniorMailingList()
    {
        String OutPutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MailingList.txt");// naming our text document mailing lis. text here and setting up its destination so that it will always just save to desktop, 
        using StreamWriter sw = new StreamWriter(OutPutPath, true);// the true here means that this list will over write other lists instead of appending to it
        using var Connection = new SQLiteConnection(ConnectionString);// stream writer is a part of the input output library, 
        try
        {// this section i sused to export the mailing list into a text document 
            Connection.Open();
            string query = "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email From SeniorPlayers;";
            using var Command = new SQLiteCommand(query, Connection);

            using var Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string FirstName = Reader.GetString(0);// gets the users first name based on its index number and 
                string LastName = Reader.GetString(1);
                string Email = Reader.GetString(2);
                string Definer = "\nAll Senior Players\n";// just used to explain what this section is on runtime does not really effect anything just formats the out put better
                string Ender = "\nEnd Of Senior Players Mailing List\n";
                string line = Definer + $"{FirstName},\n{LastName},\n{Email}" + Ender;// new stuff added add it to the rest after much testing
                sw.WriteLine(line);
            }
            MessageBox.Show("Mailing List Exported To: \n" + OutPutPath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();// closing the connnection after we are done to save resources
        }
    }
    public static void ExportJuniorMailingList()
    {
        String OutPutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MailingList.txt");
        using StreamWriter sw = new StreamWriter(OutPutPath, true);
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            string query = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email From JuniorPlayers;";
            using var Command = new SQLiteCommand(query, Connection);

            using var Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string FirstName = Reader.GetString(0);
                string LastName = Reader.GetString(1);
                string Email = Reader.GetString(2);
                string Definer = "\nAll Junior Players\n";
                string Ender = "\nEnd Of Junior Players Mailing List\n";
                string line = Definer + $"{FirstName},\n{LastName},\n{Email}" + Ender;// new stuff added add it to the rest after much testing
                sw.WriteLine(line);
            }
            MessageBox.Show("Mailing List Exported To: \n" + OutPutPath);
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

    public static void ExportAllPlayersMailingList()
    {
        String OutPutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MailingList.txt");
        using StreamWriter sw = new StreamWriter(OutPutPath, true);//overwrites preexisting document again instead of appending to it
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            string query = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email From JuniorPlayers;" + "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email From SeniorPlayers;";
            using var Command = new SQLiteCommand(query, Connection);

            using var Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string FirstName = Reader.GetString(0);
                string LastName = Reader.GetString(1);
                string Email = Reader.GetString(2);
                string Definer = "\nAll Players\n";
                string line = Definer + $"{FirstName},\n{LastName},\n{Email}";// new stuff added add it to the rest after much testing
                sw.WriteLine(line);
            }
            Reader.NextResult();//could use reader.nextresult to print out the secound items in the desired format
            while (Reader.Read())
            {
                string FirstName2 = Reader.GetString(0);
                string LastName2 = Reader.GetString(1);
                string Email2 = Reader.GetString(2);
                string Starter = "\nEnd of Junior members and begining of senior members mailing list\n";
                string Ender = "\nEnd Of All Players Mailing List\n";
                string line2 = Starter + $"{FirstName2},\n{LastName2},\n{Email2}" + Ender;// new stuff added add it to the rest after much testing
                sw.WriteLine(line2);
            }
            MessageBox.Show("Mailing List Exported To: \n" + OutPutPath);
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

    public static void ExportEveryoneMailingList()
    {
        String OutPutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MailingList.txt");// saves and creates the file to the absoulute path on desktop
        using StreamWriter sw = new StreamWriter(OutPutPath, false);//changes the mode of exportation from the stream writer from append mode meaning add to to clear or overwrite in this case
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            string query = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email From JuniorPlayers;" + "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email From SeniorPlayers;" + "Select Staff_FirstName, Staff_LastName, Staff_Email From Staff;" + "Select Coaches_FirstName, Coaches_LastName, Coaches_Email From Coaches;";
            using var Command = new SQLiteCommand(query, Connection);

            using var Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string FirstName = Reader.GetString(0);
                string LastName = Reader.GetString(1);
                string Email = Reader.GetString(2);
                string Definer = "\nAll SimplyRugby Members\n";
                string line = Definer + $"{FirstName},\n{LastName},\n{Email}";// new stuff added add it to the rest after much testing
                sw.WriteLine(line);

            }
            Reader.NextResult();
            while (Reader.Read())
            {
                string FirstName2 = Reader.GetString(0);
                string LastName2 = Reader.GetString(1);
                string Email2 = Reader.GetString(2);
                string Starter = "\nEnd of Junior members and begining of senior members mailing list\n";
                string line2 = Starter + $"{FirstName2},\n{LastName2},\n{Email2}";// new stuff added add it to the rest after much testing
                sw.WriteLine(line2);
            }
            Reader.NextResult();
            while (Reader.Read())
            {
                string FirstName3 = Reader.GetString(0);
                string LastName3 = Reader.GetString(1);
                string Email3 = Reader.GetString(2);
                string Starter = "\nEnd of Senior members and begining of Staff members mailing list\n";
                string line3 = Starter + $"{FirstName3},\n{LastName3},\n{Email3}";// new stuff added add it to the rest after much testing
                sw.WriteLine(line3);
            }
            Reader.NextResult();
            while (Reader.Read())
            {
                string FirstName4 = Reader.GetString(0);
                string LastName4 = Reader.GetString(1);
                string Email4 = Reader.GetString(2);
                string Starter = "\nEnd of Staff members and begining of Coaches mailing list\n";
                string finalEnder = "\nEnd of All Members Mailing list table\n";
                string line4 = Starter + $"{FirstName4},\n{LastName4},\n{Email4}" + finalEnder;// new stuff added add it to the rest after much testing
                sw.WriteLine(line4);
            }
            MessageBox.Show("Mailing List Exported To: \n" + OutPutPath);
        }
        catch
        {
            Connection.Close();
        }
    }

    public static void DispayAllMail(System.Windows.Controls.ListBox lstbox1)//leave it with list box 1 meaning one list box will be responsible for displaying multiple items but it will not allow the user to display both items at the same time user has to choose from either displaying everyone or a specific section.
    {
        string query = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email From JuniorPlayers;" + "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email From SeniorPlayers;" + "Select Staff_FirstName, Staff_LastName, Staff_Email From Staff;" + "Select Coaches_FirstName, Coaches_LastName, Coaches_Email From Coaches;";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            lstbox1.Items.Clear();
            DataSet ds = new DataSet();
            using var Command = new SQLiteCommand(query, Connection);
            using var Adapter = new SQLiteDataAdapter(Command);
            Adapter.Fill(ds);//using some string manipulation below to get the desired output format just to make it look nice
            // since am using multiple quiries in one above i needed to get the individual index of the items i needed 

            var JuniorPlayer = ds.Tables[0].AsEnumerable().Select(row => "Junior Players\n" + row["JPlayer_FirstName"].ToString() + " : " + row["JPlayer_LastName"].ToString() + " : " + row["JPlayer_Email"].ToString());
            var SeniorPlayer = ds.Tables[1].AsEnumerable().Select(row => "Senior Players\n" + row["SPlayer_FirstName"].ToString() + " : " + row["SPlayer_LastName"].ToString() + " : " + row["SPlayer_Email"].ToString());
            var Staff = ds.Tables[2].AsEnumerable().Select(row => "Staff\n" + row["Staff_FirstName"].ToString() + " : " + row["Staff_LastName"].ToString() + " : " + row["Staff_Email"].ToString());
            var Coaches = ds.Tables[3].AsEnumerable().Select(row => "Coaches\n" + row["Coaches_FirstName"].ToString() + " : " + row["Coaches_LastName"].ToString() + " : " + row["Coaches_Email"].ToString());
            lstbox1.ItemsSource = JuniorPlayer.Concat(SeniorPlayer).Concat(Staff).Concat(Coaches);
        }// uses linq languge integrated query to format the code to only display certain sections based on a where query 
        catch
        {// the error is caught but there will be no error message showing up
            Connection.Close();
        }
    }
    public static void DispayAllPlayersMail(System.Windows.Controls.ListBox lstbox1)// leave it with lstbox1
    {
        string query = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email From JuniorPlayers;" + "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email From SeniorPlayers;";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            lstbox1.Items.Clear();
            DataSet ds = new DataSet();
            using var Command = new SQLiteCommand(query, Connection);
            using var Adapter = new SQLiteDataAdapter(Command);
            Adapter.Fill(ds);
            var JuniorPlayer = ds.Tables[0].AsEnumerable().Select(row => "Junior Players\n" + row["JPlayer_FirstName"].ToString() + " : " + row["JPlayer_LastName"].ToString() + " : " + row["JPlayer_Email"].ToString());
            var SeniorPlayer = ds.Tables[1].AsEnumerable().Select(row => "Senior Players\n" + row["SPlayer_FirstName"].ToString() + " : " + row["SPlayer_LastName"].ToString() + " : " + row["SPlayer_Email"].ToString());
            lstbox1.ItemsSource = JuniorPlayer.Concat(SeniorPlayer);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { Connection.Close(); }
    }
    public static void DispayAllCoachesMail(System.Windows.Controls.ListBox lstbox2)
    {
        string query = "Select Coaches_FirstName, Coaches_LastName, Coaches_Email From Coaches;";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            lstbox2.Items.Clear();
            DataSet ds = new DataSet();
            using var Command = new SQLiteCommand(query, Connection);
            using var Adapter = new SQLiteDataAdapter(Command);
            Adapter.Fill(ds);
            var Coaches = ds.Tables[0].AsEnumerable().Select(row => "Coaches\n" + row["Coaches_FirstName"].ToString() + " : " + row["Coaches_LastName"].ToString() + " : " + row["Coaches_Email"].ToString());
            lstbox2.ItemsSource = (Coaches);
        }
        catch
        {
            Connection.Close();
        }
    }
    public static void DispayAllStaffMail(System.Windows.Controls.ListBox lstbox3)
    {
        string query = "Select Staff_FirstName, Staff_LastName, Staff_Email From Staff;";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            lstbox3.Items.Clear();
            DataSet ds = new DataSet();
            using var Command = new SQLiteCommand(query, Connection);
            using var Adapter = new SQLiteDataAdapter(Command);
            Adapter.Fill(ds);
            var Staff = ds.Tables[0].AsEnumerable().Select(row => "Staff\n" + row["Staff_FirstName"].ToString() + " : " + row["Staff_LastName"].ToString() + " : " + row["Staff_Email"].ToString());
            lstbox3.ItemsSource = (Staff);
        }
        catch
        {
            Connection.Close();
        }
    }
    public static void DispayAllSeniorMail(System.Windows.Controls.ListBox lstbox4)
    {
        string query = "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email From SeniorPlayers;";
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            lstbox4.Items.Clear();
            DataSet ds = new DataSet();
            using var Command = new SQLiteCommand(query, Connection);
            using var Adapter = new SQLiteDataAdapter(Command);
            Adapter.Fill(ds);
            var SeniorPlayer = ds.Tables[0].AsEnumerable().Select(row => "Senior Players\n" + row["SPlayer_FirstName"].ToString() + " : " + row["SPlayer_LastName"].ToString() + " : " + row["SPlayer_Email"].ToString());
            lstbox4.ItemsSource = (SeniorPlayer);
        }
        catch
        {
            Connection.Close();
        }
    }

    public static void DispayAllJuniorMail(System.Windows.Controls.ListBox lstbox5)// passing the list box from the other class or wpf page to this class
    {
        string query = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email From JuniorPlayers;";// this is the string query for  
        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            lstbox5.Items.Clear();
            DataSet ds = new DataSet();
            using var Command = new SQLiteCommand(query, Connection);
            using var Adapter = new SQLiteDataAdapter(Command);
            Adapter.Fill(ds);
            var JuniorPlayer = ds.Tables[0].AsEnumerable().Select(row => "Junior Players\n" + row["JPlayer_FirstName"].ToString() + " : " + row["JPlayer_LastName"].ToString() + " : " + row["JPlayer_Email"].ToString());
            lstbox5.ItemsSource = (JuniorPlayer);
        }
        catch
        {
            Connection.Close();
        }
    }
    public static void SkillPlayerFinder(System.Windows.Controls.ListBox displaymemberlstbox, string SquadID22)
    {
        string query = "SELECT 'Senior Player' as PlayerType, SPlayer_FirstName, SPlayer_LastName FROM SeniorPlayers WHERE SPlayer_ID=@SPlayer_ID UNION ALL SELECT 'Junior Player', JPlayer_FirstName, JPlayer_LastName FROM JuniorPlayers WHERE JPlayer_ID=@JPlayer_ID";

        using var Connection = new SQLiteConnection(ConnectionString);
        try
        {
            Connection.Open();
            using var Command = new SQLiteCommand(query, Connection);
            {
                DataSet ds = new DataSet();
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@JPlayer_ID", SquadID22);
                Command.Parameters.AddWithValue("@SPlayer_ID", SquadID22);
                using var Adapter = new SQLiteDataAdapter(Command);

                Adapter.Fill(ds);
                var PlayersList = ds.Tables[0].AsEnumerable().Select(row => row["PlayerType"].ToString() + "\n" + row["SPlayer_FirstName"].ToString() + " : " + row["SPlayer_LastName"].ToString());
                displaymemberlstbox.ItemsSource = PlayersList;

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

    // all these funtions will  be passed into other classes to serve a specific need based on the conditions in the other classes such as the export seniors list will only be called if the user attempts to export a mailling list consistig only of senior members based on the checkbox button option 
}




