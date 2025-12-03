using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web.Models;
using aplication.DTO;
using aplication.Interface;
using System.Threading.Tasks;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICategory icat;

       

        public HomeController(ILogger<HomeController> logger,ICategory _icat)
        {
            icat = _icat;
            _logger = logger;
        }

        public ActionResult CrCt()
        {
            CreateCategoryDTO obj = new CreateCategoryDTO();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CrCt(CreateCategoryDTO obj)
        {
            await icat.Create(obj); 
            return View();
        }


        public IActionResult Index()
        {
            return View();
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
