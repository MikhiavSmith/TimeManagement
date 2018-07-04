using System.Collections.Generic;
using TimeManagement.Models;

namespace TimeManagement.ViewModels
{
	public class HomeIndexViewModel
    {
		public IEnumerable<Activity> Activities { get; set; }
		public string CurrentMessage { get; set; }
    }
}
