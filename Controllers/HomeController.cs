using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
            .Where(l=> l.Name.Contains("Womens'"))
            .ToList();
            ViewBag.HockeySports = _context.Leagues
            .Where(l=> l.Sport.Contains("Hockey"))
            .ToList();
            ViewBag.NotFootballLeagues = _context.Leagues
            .Where(l=> l.Sport!=("Football"))
            .ToList();
            ViewBag.AllConferences = _context.Leagues
            .Where(l=> l.Name.Contains("Conference"))
            .ToList();
            ViewBag.AllAtlanticRegion = _context.Leagues
            .Where(l=> l.Name.Contains("Atlantic"))
            .ToList();
            ViewBag.DallasTeams = _context.Teams
            .Where(l=> l.Location.Contains("Dallas"))
            .ToList();
            ViewBag.Raptors = _context.Teams
            .Where(l=> l.TeamName.Contains("Raptors"))
            .ToList();
            ViewBag.AllCity = _context.Teams
            .Where(l=> l.Location.Contains("City"))
            .ToList();
            ViewBag.TNames = _context.Teams
            .Where(h => h.TeamName.StartsWith("T"))
            .ToList();
            ViewBag.AllTeams = _context.Teams
            .OrderBy(h => h.Location)
            .ToList();
            ViewBag.ReverseTeams = _context.Teams
            .OrderByDescending(h => h.Location)
            .ToList();
            ViewBag.Cooper = _context.Players
            .Where(h => h.LastName.Contains("Cooper"))
            .ToList();
            ViewBag.Joshua = _context.Players
            .Where(h => h.FirstName.Contains("Joshua"))
            .ToList();
            ViewBag.CooperNoJoshua = _context.Players
            .Where(l=> l.FirstName!=("Joshua") && l.LastName.Contains("Cooper"))
            .ToList();
            ViewBag.AlexanderWyatt = _context.Players
            .Where(h => h.FirstName.Contains("Alexander") || h.FirstName.Contains("Wyatt"))
            .ToList();;
            return View();
            
            
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}