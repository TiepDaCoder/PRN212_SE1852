using System.Windows;

namespace ButtonControl_TongHop
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

        private void Thoat(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TinhTong(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int tong = a + b;
            tbKetQua.Text = tong + "";
        }
    }
}