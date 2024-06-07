using Custome_Authorization_Filter.Models;
using Custome_Authorization_Filter.Reposiratories;
using Custome_Authorization_Filter.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Custome_Authorization_Filter.Controllers
{
    public class HomeController : Controller
    {
        UserInterface ui;
        public HomeController(UserInterface ui)
        {
            this.ui = ui;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(SignInVM rec)
        {
            if(ModelState.IsValid)
            {
                var result = this.ui.SignIn(rec);
                if(result.IsLoggedIn)
                {
                    HttpContext.Session.SetString("UserName", result.UserName);
                    HttpContext.Session.SetString("UserId", result.LoginId.ToString());

                    return RedirectToAction("Index", "UserHome", new {Area="User_Area"});
                }
                else
                {
                    ModelState.AddModelError("",result.Message);
                    return View(rec);
                }
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User rec)
        {
            if(ModelState.IsValid)
            {
                this.ui.SignUp(rec);
                return RedirectToAction("SignIn");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
