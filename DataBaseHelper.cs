using System.Data.SQLite;
using System.IO;
using System.Windows;


public static class DataBaseHelper
{
    private static string connectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
    public static void initializeDatabase()
    {
        try
        {
            if (!File.Exists(@"..\..\Files\SimplyRugby.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\Files\SimplyRugby.db");
                using var Connection = new SQLiteConnection(connectionString);
                {
                    Connection.Open();
                    using var pragmaCommand = new SQLiteCommand("PRAGMA foreign_keys = ON;", Connection);//allows me to add foreign keys.
                    pragmaCommand.ExecuteNonQuery();
                    //create all the tables for the database
                    //total of tables i need is 9.
                    // tables include: Coaches, SeniorPlayers, JuniorPlayers, Staff, Logins, MailingList, SkillLevels, Squad, EmergencyContacts
                    // address varchar225, email is also 225, names are 150, comments are 500 but ints are undefineable passwords will all be 120 varchar
                    //Tables Creation Section
                    string CreateCoachesTableQuery = @"Create Table If Not Exists Coaches(
                    Coaches_ID integer Primary Key,
                    Coaches_FirstName VARCHAR (150),
                    Coaches_LastName VARCHAR (150),
                    Coaches_Email VARCHAR (225),
                    Coaches_Address VARCHAR (225),
                    Coaches_Number Integer,
                    DOB Date,
                    Comments VARCHAR (500)
                    );";

                    string CreateSeniorPlayersTableQuery = @"Create Table If Not Exists SeniorPlayers(
                    SPlayer_ID integer Primary Key,
                    SPlayer_FirstName VARCHAR (150),
                    SPlayer_LastName VARCHAR (150),
                    SPlayer_Email VARCHAR (225),
                    SPlayer_Address VARCHAR (225),
                    SPlayer_Number Integer,
                    DOB Date,
                    Comments VARCHAR (500)
                    );";

                    string CreateJuniorPlayersTableQuery = @"Create Table If Not Exists JuniorPlayers(
                    JPlayer_ID integer Primary Key,
                    JPlayer_FirstName VARCHAR (150),
                    JPlayer_LastName VARCHAR (150),
                    JPlayer_Email VARCHAR (225),
                    JPlayer_Address VARCHAR (225),
                    JPlayer_Number Integer,
                    DOB Date,
                    Comments VARCHAR (500)
                    );";

                    string CreateStaffTableQuery = @"Create Table If Not Exists Staff(
                    Staff_ID integer Primary Key,
                    Staff_FirstName VARCHAR (150),
                    Staff_LastName VARCHAR (150),
                    Staff_Email VARCHAR (225),
                    Staff_Address VARCHAR (225),
                    Staff_Number Integer,
                    DOB Date
                    );";

                    string CreateLoginTableQuery = @"Create Table If Not Exists Login(
                   Coaches_ID integer,
                   SPlayer_ID integer,
                   JPLayer_ID integer,
                   Staff_ID integer,
                   Passwords VARCHAR (120),
                   FOREIGN Key (Coaches_ID) REFERENCES Coaches (Coaches_ID),
                   FOREIGN Key (Staff_ID) REFERENCES Staff (Staff_ID),
                   FOREIGN Key (SPlayer_ID) REFERENCES SeniorPlayers (SPlayer_ID),
                   FOREIGN Key (JPlayer_ID) REFERENCES JuniorPlayers (JPlayer_ID)
                    );";

                    string CreateSquadsTableQuery = @"CREATE TABLE IF NOT EXISTS Squads(
                   Squad_ID INTEGER PRIMARY KEY,
                   Squad_Name VARCHAR(225),
                   JPlayer_ID INTEGER,
                   SPlayer_ID INTEGER,
                   SPlayer_FirstName VARCHAR (150),
                   SPlayer_LastName VARCHAR (150),
                   JPlayer_FirstName VARCHAR (150),
                   JPlayer_LastName VARCHAR (150),
                   Comments VARCHAR(500),
                   FOREIGN KEY (JPlayer_ID) REFERENCES JuniorPlayers(JPlayer_ID),
                   FOREIGN KEY (SPlayer_ID) REFERENCES SeniorPlayers(SPlayer_ID)
                   );";



                    string CreateSkillLevelsTableQuery = @"CREATE TABLE IF NOT EXISTS SkillLevels(
                   Skill_Name VARCHAR(150),
                   Skill_Proficiency INTEGER,
                   SPlayer_FirstName VARCHAR (150),
                   SPlayer_LastName VARCHAR (150),
                   JPlayer_FirstName VARCHAR (150),
                   JPlayer_LastName VARCHAR (150),
                   JPlayer_ID INTEGER,
                   SPlayer_ID INTEGER,
                   Passing VARCHAR(500),
                   Kicking VARCHAR(500),
                   Tackling VARCHAR(500),
                   FOREIGN KEY (JPlayer_ID) REFERENCES JuniorPlayers(JPlayer_ID),
                   FOREIGN KEY (SPlayer_ID) REFERENCES SeniorPlayers(SPlayer_ID)
                   );";

                    string CreateEmergencyContactsTableQuery = @"CREATE TABLE IF NOT EXISTS EmergencyContacts(
                   Contact_ID INTEGER PRIMARY KEY,
                   Contact_FirstName VARCHAR(150) NOT NULL,
                   Contact_LastName VARCHAR(150) NOT NULL,
                   Contact_Number INTEGER,
                   Contact_Email VARCHAR(225),
                   Contact_Address VARCHAR(225),
                   Contact_DOB DATE,
                   Coaches_ID INTEGER,
                   Staff_ID INTEGER,
                   SPlayer_ID INTEGER,
                   JPlayer_ID INTEGER,
                   FOREIGN KEY (Coaches_ID) REFERENCES Coaches(Coaches_ID),
                   FOREIGN KEY (Staff_ID) REFERENCES Staff(Staff_ID),
                   FOREIGN KEY (SPlayer_ID) REFERENCES SeniorPlayers(SPlayer_ID),
                   FOREIGN KEY (JPlayer_ID) REFERENCES JuniorPlayers(JPlayer_ID)
                   );";

                    // Insert into Tables Section
                    //kenny
                    string InsertINTOCoaches = @"Insert Into Coaches( Coaches_ID, Coaches_FirstName, Coaches_LastName, Coaches_Email, Coaches_Address,Coaches_Number, DOB)  VALUES (12126487, 'Kenny', 'Vermond', 'KenVermond@Gmail.com', '56 Elmo St', 07282891928, '2000-01-12');";
                    string CoachesEmergencyContacts = @"Insert Into EmergencyContacts( Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, Coaches_ID) VALUES (48596247 , 'Ronnie', 'Wilson', 'RonnieWills@Example.com', '32 Elmo st', 74896523632 , '1995-06-16', 12126487);";
                    string CoachLogin = @"INSERT INTO Login (Coaches_ID, Passwords) VALUES ('12126487', '1236654');";
                    //emily
                    string InsertINTOSeniorPlayers = @"Insert Into SeniorPlayers( SPlayer_ID, SPlayer_FirstName, SPlayer_LastName, SPlayer_Email, SPlayer_Address,SPlayer_Number, DOB)  VALUES (12524752, 'Emily', 'Johnson', 'emily19johns@Gmail.com', '452 Elmo St', 7548372827, '1990-07-22');";
                    string SeniorEmergencyContacts = @"Insert Into EmergencyContacts( Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, SPlayer_ID) VALUES (74652364 , 'Tony', 'Mcquire', 'Tonytime@Example.com', '15 Kev st', 7596236854 , '1992-11-16', 12524752);";
                    string SeniorLogin = @"INSERT INTO Login (SPlayer_ID, Passwords) VALUES ('12524752', '123654');";
                    string SkillsSenior = @"INSERT INTO SkillLevels( SPlayer_ID, SPlayer_FirstName,SPlayer_LastName) VALUES (12524752,'Emily', 'Johnson');";
                    // Mathew
                    string InsertINTOJuniorPlayers = @"Insert Into JuniorPlayers( JPlayer_ID, JPlayer_FirstName, JPlayer_LastName, JPlayer_Email, JPlayer_Address,JPlayer_Number, DOB)  VALUES (12569874, 'Mathew', 'Clark', 'Mattie@Gmail.com', '44 Elmo St', 6541237895, '2005-07-30');";
                    string JuniorEmergencyContacts = @"Insert Into EmergencyContacts( Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Address, Contact_Number, Contact_DOB, JPlayer_ID) VALUES (75469823 , 'Kevin', 'Williams', 'WillKev110@Example.com', '56 outlands st', 785632412 , '1998-08-12', 12569874);";
                    string JuniorLogin = @"INSERT INTO Login (JPlayer_ID,Passwords) VALUES ('12569874', '123654');";
                    string SkillsJunior = @"INSERT INTO SkillLevels (JPlayer_ID, JPlayer_FirstName, JPlayer_LastName) VALUES (12569874,'Mathew', 'Clark');";
                    //John Smith
                    string insertIntoStaff = @"Insert Into Staff (Staff_ID, Staff_FirstName, Staff_LastName, Staff_Email, Staff_Address, Staff_Number, DOB) Values(10011589, 'John', 'Smith', 'john.smith@example.com', '123 Main St', 1234567890, '1985-03-15');";
                    string StaffEmergencyContact = @"Insert Into EmergencyContacts (Contact_ID, Contact_FirstName, Contact_LastName, Contact_Email, Contact_Number, Contact_Address, Contact_DOB, Staff_ID) Values (18958699,'Tom', 'Hellsing', 'Count2Dracula@example.com', 74883926738, '56 Minitour St','1999-10-10', 10011589 );";
                    string SecretaryLogin = @"INSERT INTO Login (Staff_ID,Passwords) VALUES ('10011589', '123654');";


                    // Query Exectution Section.
                    using (var Command = new SQLiteCommand(Connection))
                    {
                        Command.CommandText = CreateCoachesTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateStaffTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateSeniorPlayersTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateJuniorPlayersTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateLoginTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateEmergencyContactsTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateSquadsTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CreateSkillLevelsTableQuery;
                        Command.ExecuteNonQuery();

                        Command.CommandText = InsertINTOCoaches;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CoachesEmergencyContacts;
                        Command.ExecuteNonQuery();

                        Command.CommandText = InsertINTOSeniorPlayers;
                        Command.ExecuteNonQuery();

                        Command.CommandText = SeniorEmergencyContacts;
                        Command.ExecuteNonQuery();

                        Command.CommandText = InsertINTOJuniorPlayers;
                        Command.ExecuteNonQuery();

                        Command.CommandText = JuniorEmergencyContacts;
                        Command.ExecuteNonQuery();

                        Command.CommandText = insertIntoStaff;
                        Command.ExecuteNonQuery();

                        Command.CommandText = StaffEmergencyContact;
                        Command.ExecuteNonQuery();

                        Command.CommandText = SecretaryLogin;
                        Command.ExecuteNonQuery();

                        Command.CommandText = CoachLogin;
                        Command.ExecuteNonQuery();

                        Command.CommandText = SeniorLogin;
                        Command.ExecuteNonQuery();

                        Command.CommandText = JuniorLogin;
                        Command.ExecuteNonQuery();

                        Command.CommandText = SkillsSenior;
                        Command.ExecuteNonQuery();

                        Command.CommandText = SkillsJunior;
                        Command.ExecuteNonQuery();

                    };
                }

                Connection.Close();
            }


        }
        catch (SQLiteException ex)
        {
            MessageBox.Show(ex.Message);
        }
        // used a try and catch without a finally block.. 
    }
}