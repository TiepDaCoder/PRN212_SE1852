namespace OOP5_Clone
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Quantity}\t{Price}";
        }
        public Product clone()
        {
            return MemberwiseClone() as Product;
        }
    }
}
