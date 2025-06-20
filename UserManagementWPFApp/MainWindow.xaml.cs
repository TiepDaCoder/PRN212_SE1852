using System.Windows;
using BusinessObjects;
using Services;

namespace UserManagementWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserService uService = new UserService();
        public MainWindow()
        {
            InitializeComponent();
            HienThiToanBoUsers();
        }

        private void HienThiToanBoUsers()
        {
            List<User> users = uService.GetAllUsers();
            lbUser.ItemsSource = users;
        }
    }
}