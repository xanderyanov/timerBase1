using Microsoft.AspNetCore.Mvc;
using TimerStore.Models;

namespace TimerStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Products);

    }
}
