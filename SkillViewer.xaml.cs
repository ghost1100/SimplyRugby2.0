using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for SkillViewer.xaml
    /// </summary>
    public partial class SkillViewer : Window
    {

        public SkillViewer()
        {
            InitializeComponent();
        }

        private void modifyskills_Click(object sender, RoutedEventArgs e)
        {
            PlayerSkillsSection skillsSection = new PlayerSkillsSection();
            skillsSection.Show();
            this.Close();
        }

        private void searchbtn1231_Click(object sender, RoutedEventArgs e)
        {


            if (seniorskillsearch.IsChecked == true)
            {
                Skills.SeniorSkillsViewer(playerskillID.Text, SkillsDT);
            }
            else
            {
                Skills.JuniorSkillsViewer(playerskillID.Text, SkillsDT);
            }
        }

        private void backtodashbtn_Click(object sender, RoutedEventArgs e)
        {
            Coach_dashboard coach_Dashboard = new Coach_dashboard();
            coach_Dashboard.Show();
            this.Close();
        }

        private void SkillClearbtn_Click(object sender, RoutedEventArgs e)
        {
            if (seniorskillsearch.IsChecked == true)
            {
                Skills.SeniorSkillCleaner(playerskillID.Text);
            }
            else
            {
                Skills.JuniorSkillCleaner(playerskillID.Text);
            }
        }
    }

}

