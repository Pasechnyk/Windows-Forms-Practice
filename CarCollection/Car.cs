namespace CarCollection
{
	// Car class wth properties
    public class Car
    {
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Colour { get; set; }
		public int Year { get; set; }
		public string StateNumber { get; set; }
		public string VinNumber { get; set; }

		public override string ToString()
		{
			return $"{Brand}, {Model}, {Colour}, {Year}, {StateNumber}, {VinNumber}";
		}

	}
}
