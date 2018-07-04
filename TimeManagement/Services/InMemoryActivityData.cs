using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Models;

namespace TimeManagement.Services
{
 //   public class InMemoryActivityData : IActivityData
 //   {
	//	public InMemoryActivityData()
	//	{
	//		_activities = new List<Activity>
	//		{
	//			new Activity { Id = 1, Name = "Working on Class Project"},
	//			new Activity { Id = 2, Name = "Studying for Technical Interview"},
	//			new Activity { Id = 3, Name = "Job Search"}
	//		};
	//	}

	//	public IEnumerable<Activity> GetAll()
	//	{
	//		return _activities.OrderBy(r => r.Name);
	//	}

	//	public Activity Get(int id)
	//	{
	//		return _activities.FirstOrDefault(a => a.Id == id);
	//	}

	//	public Activity Add(Activity activity)
	//	{
	//		activity.Id = _activities.Max(a => a.Id) + 1;
	//		_activities.Add(activity);
	//		return activity;
	//	}

	//	List<Activity> _activities;
	//}
}
