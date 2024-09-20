using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for LoginIdentifier.xaml
    /// </summary>
    public partial class LoginIdentifier : Window
    {
        public LoginIdentifier()
        {
            InitializeComponent();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Window window = new LoginAsSecretary();
            window.Show();
            this.Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            LoginAsCoach window = new LoginAsCoach();
            window.Show();
            this.Close();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            LoginAsSeniorPlayer window = new LoginAsSeniorPlayer();
            window.Show();
            this.Close();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            LoginAsJuniorPlayer window = new LoginAsJuniorPlayer();
            window.Show();
            this.Close();
        }
    }
}
