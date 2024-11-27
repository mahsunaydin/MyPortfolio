using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;
using MyPortfolioUdemy.ViewModels;

namespace MyPortfolioUdemy.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult AboutList()
		{
			var aboutsModel = context.Abouts.ToList();
			var featuresModel = context.Features.ToList();

			var viewModel = new AboutFeatureViewModel
			{
				aboutList = aboutsModel,
				featureList = featuresModel
			};

			return View(viewModel);
		}

        [HttpGet]
        public IActionResult UpdateAboutFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAboutFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }











    }
}
