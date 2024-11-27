using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult Inbox()
		{
			var values = context.Messages.ToList();
            Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
            Response.Headers["Pragma"] = "no-cache";
            Response.Headers["Expires"] = "0";

            return View(values);
		}

		public IActionResult ChangeIsReadToTrue(int id)
		{
			var values = context.Messages.Find(id);
			values.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }


		public IActionResult DeleteMessage(int id)
		{
			var values = context.Messages.Find(id);
			context.Messages.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var values = context.Messages.Find(id);
			values.IsRead = true;
			context.SaveChanges();

			return View(values);
		}

		public IActionResult MessageDetailx(Message message)
		{
			return View();
		}



    }
}
