namespace EnDejtTillApplication.Models
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public Deck Deck { get; set; }
        public int CurrentPlayerIndex { get; set; }
    }
}
