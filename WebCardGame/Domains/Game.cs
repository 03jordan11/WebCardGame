using System;
using System.Collections.Generic;

namespace WebCardGame.Domains
{
	public class Game
	{
		#region Attributes
		public string Name { get; set; }
		public User User { get; set; }
		public List<AI> Bots { get; set; }
		public List<Player> TurnOrder { get; set; }
		public Deck CardStack { get; set; }
		public Deck DrawDeck { get; set; }
		public Deck Discard { get; set; }
		public int DECKSIZE { get; set; }
		public int MAXHAND { get; set; }
		#endregion
	}
}
