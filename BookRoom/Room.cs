namespace BookRoom
{
    public partial class Form1
    {
        // create Room class
        public class Room
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Contact { get; set; }
            public int AmountOfPeople { get; set; }
            public string RoomType { get; set; }
            public string Recommendation { get; set; }
            public string Date { get; set; }
        }
    }
}
