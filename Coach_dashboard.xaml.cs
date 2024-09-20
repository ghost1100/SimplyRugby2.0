using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for Coach_dashboard.xaml
    /// </summary>
    public partial class Coach_dashboard : Window
    {
        public Coach_dashboard()
        {
            InitializeComponent();
        }
        private void CoachLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginIdentifier loginIdentifier = new LoginIdentifier();
            loginIdentifier.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PlayerSkillsSection playerSkillsSection = new PlayerSkillsSection();
            playerSkillsSection.Show();
            this.Close();
        }
        private void Infobtn_Click(object sender, RoutedEventArgs e)
        {
            Information Info = new Information();
            Info.Show();
            this.Close();
        }

        private void SquadAbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DisplaySquadA(SquadDataGrid);
        }

        private void SquadBbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DisplaySquadB(SquadDataGrid);
        }

        private void SquadCbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DisplaySquadC(SquadDataGrid);
        }

        private void SquadDbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DisplaySquadD(SquadDataGrid);
        }

        private void SquadEbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.DisplaySquadE(SquadDataGrid);
        }

        private void Searchbtn12_Click(object sender, RoutedEventArgs e)// all gd
        {
            if (SearchBySquadIDChekcbox.IsChecked == true)
            {
                SQLiteDataAccess.SearchBySuqadID(SquadDataGrid, SquadID.Text);
            }
            else
            {
                SQLiteDataAccess.SearchByPlayerID(SquadDataGrid, SquadID.Text);
            }
        }

        private void viewskillsbtn_Click(object sender, RoutedEventArgs e)
        {
            SkillViewer viewskills = new SkillViewer();
            viewskills.Show();
            this.Close();
        }
    }
}







