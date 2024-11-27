using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.Title = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.Description = context.Contacts.Select(x => x.Description).FirstOrDefault();

            ViewBag.Phone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.Phone2 = context.Contacts.Select(x => x.Phone2).FirstOrDefault();

            ViewBag.Email1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.Email2 = context.Contacts.Select(x => x.Email2).FirstOrDefault();

            ViewBag.Address = context.Contacts.Select(x => x.Address).FirstOrDefault();

            return View();
        }
    }
}
