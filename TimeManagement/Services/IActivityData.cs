using TimeManagement.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TimeManagement.Services
{
	public interface IActivityData
    {
		IEnumerable<Activity> GetAll();
		Activity Get(int id);
		Activity Add(Activity activity);
		Activity Update(Activity activity);
	}
}
