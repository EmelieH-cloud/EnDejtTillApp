using EnDejtTillApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDejtTillApplication.Managers
{
   public static class GameManager
    {
        public static Deck ActiveDeck { get; set; } = new();

        public static void AddActiveDeck(string deckName)
        {
            if(deckName == "starterDeck")
            {
                StarterDeck starterDeck = new();
                ActiveDeck = starterDeck;
            }
            if (deckName == "partyDeck")
            {
                PartyDeck partyDeck = new();
                ActiveDeck = partyDeck;
            }
        }
    }
}
