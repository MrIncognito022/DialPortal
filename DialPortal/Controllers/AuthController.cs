using DialPortal.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DialPortal.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var userCredentials = _configuration.GetSection("UserCredentials").Get<List<UserCredential>>();

            var validUser = userCredentials.Find(user => user.Username == username && user.Password == password);


            if (validUser != null)
            {
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("password", password);
                return RedirectToAction("Index", "CallHistory"); // Redirect to Home page after successful login
            }

            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }

}
