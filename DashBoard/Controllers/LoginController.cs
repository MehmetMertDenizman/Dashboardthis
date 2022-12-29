using DashBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DashBoard.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Login()
        {

            var tuple = (new User(), new Restaurant());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult Login([Bind(Prefix = "Item1")] User user, [Bind(Prefix = "Item2")] Restaurant restaurant)
        {

            var tuple = (new User(), new Restaurant());
            return View(tuple);
        }
    }
}
