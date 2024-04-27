namespace EnDejtTillApplication.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new();
        public bool HasCard { get; set; }
        public int MaxHandSize { get; set; }
        public bool IsTurn { get; set; }
    }
}
