using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recap_App.Interfaces;
using Recap_App.Logic;
using Recap_App.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Recap_App.Controllers
{
    //TODO: MAP DATA FROM photosAsync()
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IBusinessLogic _businessLogic;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IBusinessLogic businessLogic)
        {
            _logger = logger;
            _context = context;
            _businessLogic = businessLogic;
        }

        public async Task<IActionResult> Index()
        {
            var payload = await _businessLogic.photosAsync();
            return View(payload);
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
