using System.Windows;
using BusinessObjects;
using Services;

namespace UserManagementWPFApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        bool isLoaded = false;
        public ProductWindow()
        {
            InitializeComponent();
            productService.InitializeDataset();
            lvProduct.ItemsSource = productService.GetAllProducts();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Id = int.Parse(txtId.Text);
            p.Name = txtName.Text;
            p.Quantity = int.Parse(txtQuantity.Text);
            p.Price = double.Parse(txtPrice.Text);
            bool kq = productService.SaveProduct(p);
            if (kq == true)
            {
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = productService.GetAllProducts();
            }
        }

        private void lvProduct_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0)
            {
                return; //Người dùng chưa chọn sản phẩm nào
            }
            //Vì coding là ta binding list product
            //nên ta lấy đối tượng Product ra:
            Product p = e.AddedItems[0] as Product;
            if (p != null)
            {
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtQuantity.Text = p.Quantity.ToString();
                txtPrice.Text = p.Price.ToString();
                isLoaded = true; //Đánh dấu là đã load sản phẩm
            }
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            if (isLoaded == false)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để cập nhật!");
                return;
            }
            Product pUpdate = new Product();
            pUpdate.Id = int.Parse(txtId.Text);
            pUpdate.Name = txtName.Text;
            pUpdate.Quantity = int.Parse(txtQuantity.Text);
            pUpdate.Price = double.Parse(txtPrice.Text);
            bool kq = productService.UpdateProduct(pUpdate);
            if (kq == true)
            {
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = productService.GetAllProducts();
                isLoaded = true;
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (isLoaded == false)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xoá!");
                return;
            }

            // Hỏi người dùng xác nhận
            MessageBoxResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xoá sản phẩm có ID = {txtId.Text} không?",
                "Xác nhận xoá",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning
            );

            if (result == MessageBoxResult.Yes)
            {
                Product pDel = new Product();
                pDel.Id = int.Parse(txtId.Text);
                bool kq = productService.DeleteProduct(pDel);
                if (kq)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetAllProducts();

                    // Reset form
                    txtId.Text = "";
                    txtName.Text = "";
                    txtQuantity.Text = "";
                    txtPrice.Text = "";
                    isLoaded = false;

                    MessageBox.Show("Đã xoá sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xoá!");
                }
            }
        }
    }
}
