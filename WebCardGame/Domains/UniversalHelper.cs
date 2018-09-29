using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCardGame.Domains
{
    public static class UniversalHelper
    {
        private static Random rng = new Random();


        public static Deck Shuffle(Deck deck)
        {
            int n = deck.Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = deck.Cards[k];
                deck.Cards[k] = deck.Cards[n];
                deck.Cards[n] = value;
            }
            return deck;
        }

        public static Deck StandardDeck()
        {
            var temp = new List<Card>();
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    temp.Add(new Card()
                    {
                        Suit = i == 0 ? "Clubs" : i == 1 ? "Diamonds" : i == 2 ? "Hearts" : "Spades",
                        Value = j + 1
                    });
                }
            }
            return Shuffle(new Deck() { Cards = temp });
        }
    }
}
