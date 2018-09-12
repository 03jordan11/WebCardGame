using System;
namespace WebCardGame.Domains
{
    public class User : Player
    {
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
    }
}
