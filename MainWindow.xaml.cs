using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, RoutedEventArgs e)
        {
            DataBaseHelper.initializeDatabase();
            Window window = new LoginIdentifier();
            window.Show();
            this.Close();
        }

        private void Quitbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank You, Have A Great Day!!");
            this.Close();
        }
    }
}