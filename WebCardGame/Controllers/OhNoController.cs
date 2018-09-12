using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCardGame.Domains;
using WebCardGame.Models;

namespace WebCardGame.Controllers
{
	public class OhNoController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			var game = new Game() {
				Name = "Oh No 99!",
				User = new User(),
				Bots = new List<AI>(),
				TurnOrder = new List<Player>(),
				CardStack = new Deck(),
				DrawDeck = new Deck(),
				DECKSIZE = 52,
				MAXHAND = 4,
				Discard = null,
			};

			var x = new OhNoViewModel() {
				OhNoGame = game
			};
			return View("Index", x);
		}
	}
}
