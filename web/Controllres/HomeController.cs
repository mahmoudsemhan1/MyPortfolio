using core.Entities;
using core.InterFaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web.ViewModels;

namespace web.Controllres
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _Onwer;
        private readonly IUnitOfWork<PortfolioItem> _Portfolio;

        public IUnitOfWork<PortfolioItem> Portfolio { get; }

        public HomeController(IUnitOfWork<Owner> Onwer , IUnitOfWork<PortfolioItem>  Portfolio)
        {
            _Onwer = Onwer;
            _Portfolio = Portfolio;
          
        }
        public IActionResult Index()
        {
            var HomViewModel = new HomeViewModel
            {
                Owner = _Onwer.Entity.GetAll().First(),
                PortfolioItems = _Portfolio.Entity.GetAll().ToList()
            };
            return View(HomViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
      
    }
}
