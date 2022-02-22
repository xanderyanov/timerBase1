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

        public ViewResult Index(string category, int productPage = 1)
        {
            var model = new ProductsListViewModel
            {
                Products = repository.Products
                  .Where(p => category == null || p.BrandName == category)
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



    }
}
