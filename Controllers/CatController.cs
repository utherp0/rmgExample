using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeowWorld.Controllers
{
    public class CatController : Controller
    {
        [HttpGet("cat/{cat}")]
        public string Cat(string cat)
        {
            switch (cat)
            {
                case "b1":
                    return "The Walkie-Talkie, London's most ugly building.";
                case "b2":
                    return "The Gherkin, the square mile, London.";
                case "b3":
                    return "Tower of London, on the banks of the Thames.";
                case "b4":
                    return "London Council Building, banks of the Thames near Tower Bridge.";
                case "b5":
                    return "Battersea Power Station.";
                case "b6":
                    return "The Shard, near London Bridge.";
            }

            return "No Such cat!";
        }

        [HttpGet("cat/all")]
        public IActionResult All()
        {
            return View();
        }

        [HttpGet("cat/version")]
        public string Version()
        {
            return "Version 1.0";
        }

    }
}