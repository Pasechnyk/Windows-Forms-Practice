namespace CarCollection
{
    // Brand class
    public class Brand
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Name} {Country}";
        }
    }
}
