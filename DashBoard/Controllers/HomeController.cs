using DashBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
namespace DashBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //public static List<User> users = new List<User>() {
        //    new User
        //    {
        //         Firstname = "Ayşe",
        //         Lastname = "Yavvaş",
        //        Email = "ayşe@ayse.com",
        //        Password = "1234" //zekam bu kadar
        //    },
        //    new User
        //    {
        //        Firstname = "Sümeyye",
        //        Lastname = "Hızlı",
        //        Email = "sumeyye@vakfi.com",
        //        Password = "99cc"
        //    }
        //};
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
        

            return View( ); 
        }
        [HttpPost]
        public RedirectToRouteResult Delete(Guid id )
        {

            //var deleteThis = users.Where(x => x.id == id).FirstOrDefault();
            //users.Remove(deleteThis);
            return new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "Home" }));
        }
        [HttpPost]
        public RedirectToRouteResult Add(User user )
        {

            
            //users.Add(user);
            return new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "Home" }));
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