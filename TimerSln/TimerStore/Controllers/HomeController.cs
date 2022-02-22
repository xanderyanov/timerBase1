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
            IQueryable<Product> Products = repository.Products
              .OrderBy(p => p.ProductID)
              .Skip((productPage - 1) * PageSize)
              .Take(PageSize);

            var brandNames = repository.Products.Select(x => x.BrandName).ToList();

            PagingInfo PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Products.Count()
            };

            var model = (Products, PagingInfo);
            
            return View(model);
        }



    }
}
