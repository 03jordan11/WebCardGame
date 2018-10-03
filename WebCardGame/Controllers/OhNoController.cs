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

			var temp = UniversalHelper.StandardDeck();
			foreach(var item in temp.Cards)
			{
				if(item.Value == 11)
				{
					item.Value = -10;
				}
				else if (item.Value == 12)
				{
					item.Value = -1;
				}
				else if (item.Value == 13)
				{
					item.Value = 0;
				}
			}

			var game = new Game()
			{
				Name = "Oh No 99!",
				User = new User(),
				Bots = new List<AI>(),
				DrawDeck = temp,
				TurnOrder = new List<Player>(),
				DECKSIZE = 52,
				MAXHAND = 4,
				Discard = null,
			};

			var x = new OhNoViewModel()
			{
				OhNoGame = game
			};
			return View("Index", x);
		}
	}
}
