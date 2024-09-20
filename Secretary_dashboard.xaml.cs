using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for Secretary_dashboard.xaml
    /// </summary>
    public partial class Secretary_dashboard : Window
    {
        public Secretary_dashboard()
        {
            InitializeComponent();
        }

        private void deleteplayer_Click(object sender, RoutedEventArgs e)
        {
            DeleteJPlayers DeleteJPlayer = new DeleteJPlayers();
            DeleteJPlayer.Show();
            this.Close();
        }

        private void viewJPlayers_Click(object sender, RoutedEventArgs e)
        {
            ViewPlayers viewer = new ViewPlayers();
            viewer.Show();
            this.Close();
        }

        private void viewSeniorplayer_Click(object sender, RoutedEventArgs e)
        {
            ViewPlayers viewer = new ViewPlayers();
            viewer.Show();
            this.Close();
        }

        private void Add_JPlayer_Click(object sender, RoutedEventArgs e)
        {
            AddPlayers AddPlayers = new AddPlayers();
            AddPlayers.Show();
            this.Close();
        }

        private void AddSPlayer_Click(object sender, RoutedEventArgs e)
        {
            AddPlayers AddPlayers = new AddPlayers();
            AddPlayers.Show();
            this.Close();
        }

        private void Seniorplayerpasswordchange_Click(object sender, RoutedEventArgs e)
        {
            PasswordChanger PasswordChange = new PasswordChanger();
            PasswordChange.Show();
            this.Close();
        }

        private void JPlayerPasswordChange_Click(object sender, RoutedEventArgs e)
        {
            PasswordChanger PasswordChange = new PasswordChanger();
            PasswordChange.Show();
            this.Close();
        }

        private void JPlayerEmergency_contacts_Click(object sender, RoutedEventArgs e)
        {
            PlayersEmergencyContacts PlayerContacts = new PlayersEmergencyContacts();
            PlayerContacts.Show();
            this.Close();
        }

        private void SeniorplayerEmergency_contacts_Click(object sender, RoutedEventArgs e)
        {
            PlayersEmergencyContacts PlayerContacts = new PlayersEmergencyContacts();
            PlayerContacts.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginIdentifier Logbackin = new LoginIdentifier();
            Logbackin.Show();
            this.Close();
        }

        private void addstaff_Click(object sender, RoutedEventArgs e)
        {
            AddStaffOrCoach AddStaff = new AddStaffOrCoach();
            AddStaff.Show();
            this.Close();
        }

        private void AddCoach_Click(object sender, RoutedEventArgs e)
        {
            AddStaffOrCoach AddStaff = new AddStaffOrCoach();
            AddStaff.Show();
            this.Close();
        }

        private void deletestaff_Click(object sender, RoutedEventArgs e)
        {
            DeleteStaffOrCoach DeleteStaff = new DeleteStaffOrCoach();
            DeleteStaff.Show();
            this.Close();
        }

        private void DeleteCoach_Click(object sender, RoutedEventArgs e)
        {
            DeleteStaffOrCoach DeleteStaff = new DeleteStaffOrCoach();
            DeleteStaff.Show();
            this.Close();
        }

        private void changestaffpassword_Click(object sender, RoutedEventArgs e)
        {
            ChangeStaffPassword ChangeCoachPassword = new ChangeStaffPassword();
            ChangeCoachPassword.Show();
            this.Close();
        }

        private void ChangeCoachPassword_Click(object sender, RoutedEventArgs e)
        {
            ChangeStaffPassword ChangeCoachPassword = new ChangeStaffPassword();
            ChangeCoachPassword.Show();
            this.Close();
        }

        private void viewstaff_Click(object sender, RoutedEventArgs e)
        {
            ViewStaff ViewAll = new ViewStaff();
            ViewAll.Show();
            this.Close();
        }

        private void ViewCoaches_Click(object sender, RoutedEventArgs e)
        {
            ViewStaff ViewAll = new ViewStaff();
            ViewAll.Show();
            this.Close();
        }

        private void staffemergency_Click(object sender, RoutedEventArgs e)
        {
            StaffEmergency MembersEmergency = new StaffEmergency();
            MembersEmergency.Show();
            this.Close();
        }

        private void CoachEmergencyContact_Click(object sender, RoutedEventArgs e)
        {
            StaffEmergency MembersEmergency = new StaffEmergency();
            MembersEmergency.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MailingList maillst = new MailingList();
            maillst.Show();
            this.Close();
        }

        private void updatedetails_Click(object sender, RoutedEventArgs e)
        {
            UpdateDetails DetailsUpdater = new UpdateDetails();
            DetailsUpdater.Show();
            this.Close();
        }
    }
}

