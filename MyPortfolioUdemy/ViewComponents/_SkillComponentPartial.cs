using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext porftolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = porftolioContext.Skills.ToList();
            return View(values);
        }
    }
}
