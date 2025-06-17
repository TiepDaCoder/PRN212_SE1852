using System.Windows;

namespace ListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
        }
        void HienThiDanhSach()
        {
            lstDuLieu.Items.Clear();
            for (int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                lstDuLieu.Items.Add(x);
            }
        }
        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);
            int vt = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(vt, x);
            HienThiDanhSach();
            txtGiaTriChen.Text = "";
            txtViTriChen.Text = "";
        }
        private void BtnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhSach();
        }
        private void BtnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhSach();
        }
        private void BtnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xoá được!", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            dsDuLieu.RemoveAt(lstDuLieu.SelectedIndex);
            HienThiDanhSach();
        }
        private void BtnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xoá được!", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            while (lstDuLieu.SelectedItems.Count > 0)
            {
                int data = (int)lstDuLieu.SelectedItems[0];
                dsDuLieu.Remove(data);
                lstDuLieu.Items.Remove(data);
            }
        }
        private void BtnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhSach();
        }

        private void btnXoaTatCa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
