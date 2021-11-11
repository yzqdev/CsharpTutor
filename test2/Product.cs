using System;

namespace test2
{
    internal class Product
    {
        public Product()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; internal set; }
        public decimal Price { get; internal set; }
        public string[] Sizes { get; internal set; }
    }
}