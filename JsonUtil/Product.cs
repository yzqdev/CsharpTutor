namespace MyApp
{
    internal class Product
    {
        public string? Name { get;   set; }
        public DateTime ExpiryDate { get; internal set; }
        public decimal Price { get; internal set; }
        public string[] Sizes { get; internal set; }
    }
}