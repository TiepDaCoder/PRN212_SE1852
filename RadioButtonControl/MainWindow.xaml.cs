using System.Windows;

namespace RadioButtonControl
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
        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhChon = "";
            if (radRatTot.IsChecked == true)
            {
                binhChon = radRatTot.Content + "";
            }
            else if (radTot.IsChecked == true)
            {
                binhChon = radTot.Content + "";
            }
            else if (radTamTam.IsChecked == true)
            {
                binhChon = radTamTam.Content + "";
            }
            else if (radKhongOk.IsChecked == true)
            {
                binhChon = radKhongOk.Content + "";
            }

            string gioiTinh = "";
            if (radNam.IsChecked == true)
            {
                gioiTinh = radNam.Content + "";
            }
            else if (radNu.IsChecked == true)
            {
                gioiTinh = radNu.Content + "";
            }

            string infor = "Bạn đã chọn: " + binhChon + Environment.NewLine;
            infor += "Giới tính: " + gioiTinh;
            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ret == MessageBoxResult.Yes)
            {

            }
        }
        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}