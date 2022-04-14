using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("admin/Bloglar");
        }
    }
}
