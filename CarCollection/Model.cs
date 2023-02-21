namespace CarCollection
{
    // Model class
    public class Model
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price}";
        }
    }
}
