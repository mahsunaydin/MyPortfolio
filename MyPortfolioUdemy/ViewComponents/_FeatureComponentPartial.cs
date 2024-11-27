using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext porfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = porfolioContext.Features.ToList();
            return View(values);
        }
    }
}
