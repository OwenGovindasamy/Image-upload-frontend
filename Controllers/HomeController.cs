using Microsoft.AspNetCore.Mvc;
using Recap_App.Interfaces;
using System.Threading.Tasks;

namespace Recap_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBusinessLogic _businessLogic;

        public HomeController(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _businessLogic.photosAsync());
        }
    }
}
