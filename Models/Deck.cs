namespace EnDejtTillApplication.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

    }

    public class PartyDeck : Deck
    {
        public static List<Card> Cards { get; set; } =
        new List<Card>
        {
            new Card
            {
                Text = "Hen har aldrig hört talas om Rysslands invasion av Ukraina"
            },
              new Card
            {
                Text = "Hens största dröm är att jobba som clown"
            },
                new Card
            {
                Text = "Hen har tidigare varit med i ett kriminellt gäng"
            }
        };
    }

    public class StarterDeck : Deck
    {
        public static List<Card> Cards { get; set; } =
        new List<Card>
        {
            new Card
            {
                Text = "Hen har inget hår på huvudet"
            },
              new Card
            {
                Text = "Hen tror inte på växthuseffekten"
            },
                new Card
            {
                Text = "Hen är tjugo kilo tyngre än vad hen var på bilden."
            }
        };
    }
}
