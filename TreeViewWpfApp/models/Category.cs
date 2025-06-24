namespace TreeViewWpfApp.models
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
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
