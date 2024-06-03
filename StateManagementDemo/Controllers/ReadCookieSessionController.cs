using Microsoft.AspNetCore.Mvc;

namespace StateManagementDemo.Controllers
{
    public class ReadCookieSessionController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ReadCookieSessionController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult ReadCookie()
        {
            if (_httpContextAccessor.HttpContext != null)
            {
                // Read value from cookie.
                ViewBag.Email = _httpContextAccessor.HttpContext.Request.Cookies["email"];
            }
            return View();
        }

        public IActionResult ReadSession()
        {
            ViewBag.Email = HttpContext.Session.GetString("email");
            //string role=HttpContext.Session.GetString("roleId");
            return View();
        }

    }
}
