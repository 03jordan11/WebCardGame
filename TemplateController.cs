using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCardGame.Domains;
using WebCardGame.Models;

namespace WebCardGame.Controllers
{
    public class TemplateController : Controller
    {

        public IActionResult Index()
        {
            var game = new Game()
            {
                //If your deck takes a different amount or type of cards, 
                //feel free to add a method in the UniversalHelper class to deal with this
                DrawDeck = UniversalHelper.StandardDeck()
            };
            var model = new TemplateViewModel()
            {
                TemplateGame = game
            };
            return View(model);
        }

    }
}
