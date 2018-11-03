using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCardGame.Domains;
using WebCardGame.Models;

namespace WebCardGame.Controllers
{
    public class FeudController : Controller
    {

        public IActionResult Index()
        {
            var game = new Game()
            {
                Name = "Feud",
                User = null,
                DrawDeck = UniversalHelper.StandardDeck(),
                DECKSIZE = 52,
                MAXHAND = 0
            };
            var model = new FeudViewModel()
            {
                FeudGame = game
            };
            return View(model);
        }

    }
}
