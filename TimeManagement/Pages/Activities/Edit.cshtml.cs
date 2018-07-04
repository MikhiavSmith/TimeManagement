using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeManagement.Models;
using TimeManagement.Services;

namespace TimeManagement.Pages.Activities
{
	[Authorize]
	public class EditModel : PageModel
    {
		private IActivityData _activityData;

		[BindProperty]
		public Activity Activity { get; set; }

		public EditModel(IActivityData activityData)
		{
			_activityData = activityData;
		}

        public IActionResult OnGet(int id)
        {
			Activity = _activityData.Get(id);
			if(Activity == null)
			{
				return RedirectToAction("Index", "Home");
			}
			return Page();
        }

		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				_activityData.Update(Activity);
				return RedirectToAction("Details", "Home", new { id = Activity.Id });
			}
			return Page();
		}
    }
}