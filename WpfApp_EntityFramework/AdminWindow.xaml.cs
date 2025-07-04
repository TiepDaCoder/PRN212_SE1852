using System.Windows;
using System.Windows.Controls;
using BusinessObjects_EntityFramework;
using Services_EntityFramework;

namespace WpfApp_EntityFramework
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        ICategoryService iCategoryService = new CategoryService();
        IProductService iProductService = new ProductService();
        public AdminWindow()
        {
            InitializeComponent();
            LoadCategoriesAndProductIntoTreeView();
        }

        private void LoadCategoriesAndProductIntoTreeView()
        {
            //Tạo nút gốc:
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng Cát Lái";
            tvCategory.Items.Add(root);
            //Nạp danh mục:
            List<Category> categories = iCategoryService.GetCategories();
            foreach (Category category in categories)
            {
                //Tạo Cate Node:
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);

                //Đọc danh sách sản phẩm thuộc danh mục:
                category.Products = iProductService.GetProductsByCategory(category.CategoryId);
                //Nạp sản phẩm vào Node Cate:
                foreach (Product product in category.Products)
                {
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }
            }
            root.ExpandSubtree();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue == null)
                return;
            TreeViewItem item = e.NewValue as TreeViewItem;
            Object data = item.Tag;
            if (data == null)
            {
                //có thể là người dùng nhấn vào nút GỐC
                List<Product> products = iProductService.GetProducts();
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
                return;
            }

            if (data is Category)
            {//Người dùng bấm vào nút Category
                Category category = (Category)data;
                List<Product> products = iProductService
                                    .GetProductsByCategory(category.CategoryId);
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
            else if (data is Product)
            {//người dùng bấm vào nút Product
                List<Product> products = new List<Product>();
                products.Add(data as Product);
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
            else
            {//có thể là người dùng nhấn vào nút GỐC
                List<Product> products = iProductService.GetProducts();
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}