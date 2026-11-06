using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RateCustomers.Models;

namespace RateCustomers.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        // GET: HomeController
        public IActionResult Index()
        {
            
            HomePageModel homePageModel = new HomePageModel{LoginName = "Victor", Password = "Jesus", ConfirmPassword = "Jesus"};
            ViewData["appTitle"] = "Rating Customers";
            ViewData["homePageModel"] = homePageModel;

            return View();
        }

    }
}
