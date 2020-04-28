using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Instagrames.Models;
using Microsoft.EntityFrameworkCore;

namespace Instagrames.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InstaDb db;

        public HomeController(ILogger<HomeController> logger, InstaDb fromstartupcs)
        {
            _logger = logger;
            db = fromstartupcs;
        }

        public IActionResult Index()
        {
            return View(db.Users.Include(u => u.Posts).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
