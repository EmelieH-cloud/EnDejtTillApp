using EnDejtTillApplication.Models;

namespace EnDejtTillApplication.Managers
{
    public static class PlayerManager
    {
        public static List<Player> Players { get; set; } = new();

        public static void AddActivePlayers(List<string> players)
        {
            foreach (string player in players)
            {
                Player playerObj = new Player
                {
                    Name = player,
                    HasCard = false,
                    MaxHandSize = 10
                };

                Players.Add(playerObj);
            }

        }
    }
}
