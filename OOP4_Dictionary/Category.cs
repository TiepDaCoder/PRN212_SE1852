namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }

        //CRUD
        //Thêm mới 1 sản phẩm cho Category
        public void AddProduct(Product p)
        {
            //Nếu chưa tồn tại thì mới đưa vào Dictionary
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p); //Tự động gọi ToString()
            }
        }
        //Lấy chi tiết 1 đối tượng
        public Product GetProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return null;
            }
            return Products[id];
        }
        public Dictionary<int, Product> SortProduct()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }
        public Dictionary<int, Product> ComplexSort()
        {
            return Products.OrderByDescending(item => item.Value.Quantity).
                            OrderBy(item => item.Value.Price).
                            ToDictionary<int, Product>();
        }
        public void EditProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                return;
            }
            //Sửa dữ liệu tại ô nhớ có chứa p.Id:
            Products[p.Id] = p;
        }
        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(Id) == false)
            {
                return false;
            }
            return Products.Remove(id);
        }
        /*
         * Xoá tất cả sản phẩm bán ế trong quý 1 năm 2025
         * ế: Bán chỉ được 1 đơn hàng
         */
    }
}
