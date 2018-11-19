using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCardGame.Domains;

namespace WebCardGame.Models
{
    public class TemplateViewModel
    {
        public Game TemplateGame { get; set; }
        
        //if there is anything else you would like to pass to the game, please do so in this file.
    } 
}
