﻿namespace TreeViewWpfApp.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
