using System.Windows;
namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for ViewStaff.xaml
    /// </summary>
    public partial class ViewStaff : Window
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void DashReturnbtn_Click(object sender, RoutedEventArgs e)
        {
            Secretary_dashboard Dashboard = new Secretary_dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {

            SQLiteDataAccess.SearchV8(Searchalltxt.Text, CoachDataGrid);
        }

        private void ViewAllbtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.ViewAllStaff(CoachDataGrid);
        }

        private void ViewAllbtn2_Click(object sender, RoutedEventArgs e)
        {

            SQLiteDataAccess.ViewAllCoaches(CoachDataGrid);
        }
    }
}
// reflections: the further i went into this project the more ideas for improvments that i have had immplemeting them with the time limit it may be a tough challenge though./note imanaged to learn how to use inheritance now coding seems more fun am kinda challenging my self to make the biggest class possible.
// note reconfigure the clean up or brush tool at the bottom and use it later to make the code clearner.