using Microsoft.AspNetCore.Mvc;

namespace TimerStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() =>  View();
    }
}
