﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
		{
			ViewBag.IsNotReadMessageCount = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
			var values = context.ToDoLists.Where(x => x.Status == false).ToList();
			return View(values);
		}
	}
}
