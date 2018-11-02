using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCardGame.Domains;
using WebCardGame.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebCardGame.Controllers
{
    public class PassController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var game = new Game()
            {
                Name = "1,2,3 Pass!",
                User = new User(),
                Bots = new List<AI>(),
                TurnOrder = new List<Player>(),
                CardStack = new Deck(),
                DrawDeck = UniversalHelper.Pass(5),
                DECKSIZE = 52,
                MAXHAND = 4,
                Discard = null,
            };

            var x = new PassViewModel()
            {
                PassGame = game
            };
            return View("Index", x);
        }
    }
}
