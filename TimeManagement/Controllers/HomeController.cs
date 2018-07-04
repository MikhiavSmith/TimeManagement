using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeManagement.Models;
using TimeManagement.Services;
using TimeManagement.ViewModels;

namespace TimeManagement.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private IActivityData _activityData;
		private IGreeter _greeter;

		public HomeController(IActivityData activityData,
							  IGreeter greeter)
		{
			_activityData = activityData;
			_greeter = greeter;
		}

		[AllowAnonymous]
		public IActionResult Index()
		{
			var model = new HomeIndexViewModel();
			model.Activities = _activityData.GetAll();
			model.CurrentMessage = _greeter.GetMessageOfTheDay();

			return View(model);
		}

		public IActionResult Details(int id)
		{
			var model = _activityData.Get(id);
			if (model == null)
			{
				return RedirectToAction(nameof(Index));
			}
			return View(model);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ActivityEditModel model)
		{
			if(ModelState.IsValid)
			{
				var newActivity = new Activity();
				newActivity.Name = model.Name;
				newActivity.Category = model.Category;

				_activityData.Add(newActivity);

				return RedirectToAction(nameof(Details), new { id = newActivity.Id });
			}
			else
			{
				return View();
			}
		}
    }
}
