namespace Shop
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Country { get; set; }
        public int Amount { get; set; }
        public decimal Discount { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price} {Country} {Amount} {Discount}%";
        }
    }
}
