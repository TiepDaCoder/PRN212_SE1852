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
    }
}
