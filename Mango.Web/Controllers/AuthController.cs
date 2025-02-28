using Mango.Web.Models;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mango.Web.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto login = new LoginRequestDto();
            return View(login);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text = SD.RoleAdmin, Value = SD.RoleAdmin},
                new SelectListItem{Text = SD.RoleCustomer, Value = SD.RoleCustomer},
            };

            //pass role list to Register view. use ViewBag to pass data to view
            ViewBag.RoleList = roleList;

            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
