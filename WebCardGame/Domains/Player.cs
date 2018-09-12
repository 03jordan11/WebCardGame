using System;
namespace WebCardGame.Domains
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public Card LastCardPlayed { get; set; }
        public Card PlayedCard { get; set; }
        public int? Score { get; set; }
    }
}
