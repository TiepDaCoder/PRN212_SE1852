using System.Windows;
using System.Windows.Controls;
using MyStoreWpfApp_EntityFrameWork.Models;

namespace MyStoreWpfApp_EntityFrameWork
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        bool isLoaded_ListView = false;
        public AdminWindow()
        {
            InitializeComponent();
            DisplayCategoriesAndProducts();
        }

        private void DisplayCategoriesAndProducts()
        {
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng Trà Vinh";
            tvCategory.Items.Add(root);

            //duyệt vòng lặp qua tất cả các danh mục
            var categories = context.Categories.ToList();
            foreach (var category in categories)
            {
                //Tạo node Category:
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);
                //vòng lặp duyệt qua các Sản phẩm của Category:
                var products = context.Products
                    .Where(p => p.CategoryId == category.CategoryId)
                    .ToList();
                foreach (var product in products)
                {
                    //tạo node Product:
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }
            }
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            isLoaded_ListView = false;
            TreeViewItem item = e.NewValue as TreeViewItem;
            if (item != null)
            {
                Category category = item.Tag as Category;
                if (category != null)
                {
                    //nạp sản phẩm của danh mục lên giao diện ListView
                    var products = context.Products
                   .Where(p => p.CategoryId == category.CategoryId)
                   .ToList();
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }
            }
            isLoaded_ListView = true;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLoaded_ListView = false) return;
            if (e.AddedItems.Count <= 0) return;
            Product product = e.AddedItems[0] as Product;
            txtProductId.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProductName;
            txtUnitsInStock.Text = product.UnitsInStock + "";
            txtUnitPrice.Text = product.UnitPrice + "";
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtUnitsInStock.Text = "";
            txtUnitPrice.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Chức năng thêm mới
            //B1: Cần biết được Danh mục nào để lưu product vào
            TreeViewItem selectedItem = tvCategory.SelectedItem as TreeViewItem;
            Category category = selectedItem?.Tag as Category;
            if (category == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //B2: Tạo mới sản phẩm
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.UnitsInStock = short.Parse(txtUnitsInStock.Text);
            p.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            //tham chiếu khoá ngoại
            p.CategoryId = category.CategoryId;

            //đánh dấu thêm mới
            context.Products.Add(p);
            //xác nhận thêm mới
            context.SaveChanges();
            MessageBox.Show("Đã thêm mới sản phẩm thành công");

            RefreshUI(category, p);
        }

        private void RefreshUI(Category selectedCategory, Product newOrUpdatedProduct)
        {
            foreach (TreeViewItem root in tvCategory.Items)
            {
                foreach (TreeViewItem catNode in root.Items)
                {
                    if (catNode.Tag is Category cat && cat.CategoryId == selectedCategory.CategoryId)
                    {
                        if (newOrUpdatedProduct != null)
                        {
                            // THÊM HOẶC CẬP NHẬT
                            TreeViewItem existingProductNode = null;
                            foreach (TreeViewItem child in catNode.Items)
                            {
                                if (child.Tag is Product prod && prod.ProductId == newOrUpdatedProduct.ProductId)
                                {
                                    existingProductNode = child;
                                    break;
                                }
                            }

                            if (existingProductNode != null)
                            {
                                // Cập nhật tên nếu đã tồn tại
                                existingProductNode.Header = newOrUpdatedProduct.ProductName;
                                existingProductNode.Tag = newOrUpdatedProduct;
                            }
                            else
                            {
                                // Thêm mới nếu chưa có
                                TreeViewItem newProductNode = new TreeViewItem
                                {
                                    Header = newOrUpdatedProduct.ProductName,
                                    Tag = newOrUpdatedProduct
                                };
                                catNode.Items.Add(newProductNode);
                            }
                        }
                        else
                        {
                            // XOÁ
                            catNode.Items.Clear();
                            var products = context.Products
                                .Where(p => p.CategoryId == selectedCategory.CategoryId)
                                .ToList();

                            foreach (var p in products)
                            {
                                TreeViewItem productNode = new TreeViewItem
                                {
                                    Header = p.ProductName,
                                    Tag = p
                                };
                                catNode.Items.Add(productNode);
                            }
                        }

                        // Luôn chọn lại danh mục sau khi thao tác
                        tvCategory.SelectedItemChanged -= tvCategory_SelectedItemChanged;
                        catNode.IsSelected = true;
                        catNode.IsExpanded = true;
                        tvCategory.SelectedItemChanged += tvCategory_SelectedItemChanged;

                        break;
                    }
                }
            }

            // Cập nhật lại danh sách sản phẩm trong ListView
            lvProduct.ItemsSource = context.Products
                .Where(p => p.CategoryId == selectedCategory.CategoryId)
                .ToList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để cập nhật.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            int productId = int.Parse(txtProductId.Text);
            Product productToUpdate = context.Products.Find(productId);
            if (productToUpdate == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // Cập nhật thông tin sản phẩm
            productToUpdate.ProductName = txtProductName.Text;
            productToUpdate.UnitsInStock = short.Parse(txtUnitsInStock.Text);
            productToUpdate.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            // Lưu thay đổi
            context.SaveChanges();
            MessageBox.Show("Cập nhật sản phẩm thành công.");
            RefreshUI(productToUpdate.Category, productToUpdate);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Xoá sản phẩm
            //B1: Kiểm tra có sản phẩm nào được chọn không
            int id = int.Parse(txtProductId.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xoá.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //B2: Xoá sản phẩm
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sản phẩm {product.ProductName} không?", "Xoá sản phẩm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Products.Remove(product);
                context.SaveChanges();
                MessageBox.Show("Đã xoá sản phẩm thành công.");
                //Cập nhật lại giao diện
                RefreshUI(product.Category, null);
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtUnitsInStock.Text = "";
                txtUnitPrice.Text = "";
            }
            else
            {
                return;
            }
        }

    }
}