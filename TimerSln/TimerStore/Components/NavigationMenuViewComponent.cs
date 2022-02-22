using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TimerStore.Models;
namespace TimerStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.BrandName)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

