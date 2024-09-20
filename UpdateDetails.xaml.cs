using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for UpdateDetails.xaml
    /// </summary>
    public partial class UpdateDetails : Window
    {
        public string ConnectionString { get; private set; }

        public UpdateDetails()
        {
            InitializeComponent();

        }

        private void bctd_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard secretary = new Secretary_dashboard();
            secretary.Show();
            this.Close();
        }


        //updates the numbers based on check boxes or radio buttons 
        private void update_number_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(srchtxtbx.Text))
            {
                MessageBox.Show(" User Id is missing");
                return;
            }
            if (UpdateCoaches.IsChecked == true)
            {

                Updater.UpdateCoachesNumber(srchtxtbx.Text, ChangeNumber.Text);
            }

            if (UpdateSeniorPlayers.IsChecked == true)
            {
                Updater.UpdateSPNumber(srchtxtbx.Text, ChangeNumber.Text);
            }

            if (UpdateStaff.IsChecked == true)
            {
                Updater.UpdateStaffNumber(srchtxtbx.Text, ChangeNumber.Text);
            }

            if (UpdateJuniorPlayers.IsChecked == true)
            {
                Updater.UpdateJPNumber(srchtxtbx.Text, ChangeNumber.Text);
            }


        }

        //updates users address based on radio buttons
        private void Update_Address_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(srchtxtbx.Text))
            {
                MessageBox.Show("User Id is missing");
                return;
            }
            if (UpdateCoaches.IsChecked == true)
            {

                Updater.UpdateCoachesAddress(srchtxtbx.Text, ChangeAddress.Text);
            }

            if (UpdateSeniorPlayers.IsChecked == true)
            {
                Updater.UpdateSeniorPlayersAddress(srchtxtbx.Text, ChangeAddress.Text);
            }

            if (UpdateStaff.IsChecked == true)
            {
                Updater.UpdateStaffAddress(srchtxtbx.Text, ChangeAddress.Text);
            }

            if (UpdateJuniorPlayers.IsChecked == true)
            {
                Updater.UpdateJuniorPlayersAddress(srchtxtbx.Text, ChangeAddress.Text);
            }

        }

        private void update_Email_Click(object sender, RoutedEventArgs e)

        {
            if (string.IsNullOrEmpty(srchtxtbx.Text))
            {
                MessageBox.Show("User Id is missing");
                return;
            }
            if (UpdateCoaches.IsChecked == true)
            {

                Updater.UpdateCoachesEmail(srchtxtbx.Text, ChangeEmail.Text);
            }

            if (UpdateSeniorPlayers.IsChecked == true)
            {
                Updater.UpdateSeniorPlayersEmail(srchtxtbx.Text, ChangeEmail.Text);
            }

            if (UpdateStaff.IsChecked == true)
            {
                Updater.UpdateStaffEmail(srchtxtbx.Text, ChangeEmail.Text);
            }

            if (UpdateJuniorPlayers.IsChecked == true)
            {
                Updater.UpdateJuniorPlayersEmail(srchtxtbx.Text, ChangeEmail.Text);
            }

        }

        private void add_new_emergency_contact_Click(object sender, RoutedEventArgs e)

        {
            if (string.IsNullOrEmpty(srchtxtbx.Text))
            {
                MessageBox.Show("User Id is missing");
                return;
            }
            if (UpdateCoaches.IsChecked == true)
            {

                SQLiteDataAccess.InsertIntoEmergencyContactsCoaches(ContactID.Text, ContactFirstName.Text, ContactLastName.Text, ContactEmail.Text, ContactAddress.Text, ContactNumber.Text, ContactDOB.Text, srchtxtbx.Text);
            }

            if (UpdateSeniorPlayers.IsChecked == true)
            {
                SQLiteDataAccess.InsertIntoEmergencyContactsSeniors(ContactID.Text, ContactFirstName.Text, ContactLastName.Text, ContactEmail.Text, ContactAddress.Text, ContactNumber.Text, ContactDOB.Text, srchtxtbx.Text);
            }

            if (UpdateStaff.IsChecked == true)
            {
                SQLiteDataAccess.InsertIntoEmergencyContactsStaff(ContactID.Text, ContactFirstName.Text, ContactLastName.Text, ContactEmail.Text, ContactAddress.Text, ContactNumber.Text, ContactDOB.Text, srchtxtbx.Text);
            }


            if (UpdateJuniorPlayers.IsChecked == true)
            {
                SQLiteDataAccess.InsertIntoEmergencyContactsJuniors(ContactID.Text, ContactFirstName.Text, ContactLastName.Text, ContactEmail.Text, ContactAddress.Text, ContactNumber.Text, ContactDOB.Text, srchtxtbx.Text);
            }

        }

        private void delete_old_emergency_contact_Click(object sender, RoutedEventArgs e)
        {
            Updater.DeleteEmergencyContact(srchtxtbx.Text);
        }

        private void Verification(System.Windows.Controls.ListBox lstbox114, string srchtxtbx)
        {
          
            if (string.IsNullOrEmpty(srchtxtbx))
            {
                MessageBox.Show("User Id is missing");
                return;
            }
        }
        
        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
           
            string ConnectionString = @"Data Source=..\..\Files\SimplyRugby.db;Version=3;";
            using (var Connection = new SQLiteConnection(ConnectionString))
            {

                try
                {
                    Connection.Open();
                    if (UpdateCoaches.IsChecked == true)
                    {
                        string query1 = "Select Coaches_FirstName, Coaches_LastName, Coaches_Email, Coaches_Number, Coaches_Address From Coaches where Coaches_ID=@Coaches_ID;";
                        DataSet ds = new DataSet();
                        using var Command = new SQLiteCommand(query1, Connection);
                        Command.Parameters.AddWithValue("@Coaches_ID", srchtxtbx.Text);
                        using var Adapter = new SQLiteDataAdapter(Command);
                        Adapter.Fill(ds);
                        var Coaches = ds.Tables[0].AsEnumerable().Select(row => "Coach\n" + row["Coaches_FirstName"].ToString() + " : " + row["Coaches_LastName"].ToString() + " : " + row["Coaches_Email"] + " : " + row["Coaches_Address"] + " : " + row["Coaches_Number"].ToString());
                        lstbox114.ItemsSource = (Coaches);
                        Verification(lstbox114, srchtxtbx.Text);
                    }

                    if (UpdateSeniorPlayers.IsChecked == true)
                    {
                        string query2 = "Select SPlayer_FirstName, SPlayer_LastName, SPlayer_Email,SPlayer_Number, SPlayer_Address  From SeniorPlayers where SPlayer_ID=@SPlayer_ID;";
                        DataSet ds = new DataSet();
                        using var Command = new SQLiteCommand(query2, Connection);
                        Command.Parameters.AddWithValue("@SPlayer_ID", srchtxtbx.Text);
                        using var Adapter = new SQLiteDataAdapter(Command);
                        Adapter.Fill(ds);
                        var SeniorPlayer = ds.Tables[0].AsEnumerable().Select(row => "SeniorPlayer\n" + row["SPlayer_FirstName"].ToString() + " : " + row["SPlayer_LastName"].ToString() + " : " + row["SPlayer_Email"] + " : " + row["SPlayer_Address"] + " : " + row["SPlayer_Number"].ToString());
                        lstbox114.ItemsSource = (SeniorPlayer);
                        Verification(lstbox114, srchtxtbx.Text);
                    }

                    if (UpdateStaff.IsChecked == true)
                    {
                        string query3 = "Select Staff_FirstName, Staff_LastName, Staff_Email, Staff_Number, Staff_Address From Staff where Staff_ID=@Staff_ID;";
                        DataSet ds = new DataSet();
                        using var Command = new SQLiteCommand(query3, Connection);
                        Command.Parameters.AddWithValue("@Staff_ID", srchtxtbx.Text);
                        using var Adapter = new SQLiteDataAdapter(Command);
                        Adapter.Fill(ds);
                        var Staff = ds.Tables[0].AsEnumerable().Select(row => "Staff Member\n" + row["Staff_FirstName"].ToString() + " : " + row["Staff_LastName"].ToString() + " : " + row["Staff_Email"] + " : " + row["Staff_Address"] + " : " + row["Staff_Number"].ToString());
                        lstbox114.ItemsSource = (Staff);
                        Verification(lstbox114, srchtxtbx.Text);
                    }
                    //searches table for junior player
                    if (UpdateJuniorPlayers.IsChecked == true)
                    {
                        string query4 = "Select JPlayer_FirstName, JPlayer_LastName, JPlayer_Email, JPlayer_Number, JPlayer_Address From JuniorPlayers where JPlayer_ID=@JPlayer_ID;";
                        DataSet ds = new DataSet();
                        using var Command = new SQLiteCommand(query4, Connection);
                        Command.Parameters.AddWithValue("@JPlayer_ID", srchtxtbx.Text);
                        using var Adapter = new SQLiteDataAdapter(Command);
                        Adapter.Fill(ds);
                        var JuniorPlayer = ds.Tables[0].AsEnumerable().Select(row => "Junior Players\n" + row["JPlayer_FirstName"].ToString() + " : " + row["JPlayer_LastName"].ToString() + " : " + row["JPlayer_Email"] + " : " + row["JPlayer_Address"] + " : " + row["JPlayer_Number"].ToString());
                        lstbox114.ItemsSource = (JuniorPlayer);
                        Verification(lstbox114, srchtxtbx.Text);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.Close();
                }
              

            }
        }


    }
}//variables and methods shouldnt be capitals, getters and setters should be capitals, 