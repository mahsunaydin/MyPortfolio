﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = _context.Testimonials.ToList();
            return View(value);
        }
    }
}
