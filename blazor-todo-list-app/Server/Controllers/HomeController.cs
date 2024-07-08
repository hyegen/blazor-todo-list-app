using Microsoft.AspNetCore.Mvc;

namespace blazor_todo_list_app.Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
