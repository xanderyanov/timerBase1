using Microsoft.AspNetCore.Mvc;
using TimerStore.Models;
using System.Linq;
using TimerStore.Models.ViewModels;


namespace TimerStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(int productPage = 1)
        {
            var model = new ProductsListViewModel
            {
                Products = repository.Products
                  .OrderBy(p => p.ProductID)
                  .Skip((productPage - 1) * PageSize)
                  .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            };
            
            return View(model);
        }

        //public ViewResult Index(int productPage = 1)
        //=> View(repository.Products
        //    .OrderBy(p => p.ProductID)
        //    .Skip((productPage - 1) * PageSize)
        //    .Take(PageSize));


        //public IActionResult Index() => View(repository.Products);

    }
}
