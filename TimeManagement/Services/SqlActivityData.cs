using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Data;
using TimeManagement.Models;
using TimeManagement.Services;

namespace TimeManagement.Services
{
	public class SqlActivityData : IActivityData
	{
		private TimeManagementDbContext _context;

		public SqlActivityData(TimeManagementDbContext context)
		{
			_context = context;
		}

		public Activity Add(Activity activity)
		{
			_context.Activities.Add(activity);
			_context.SaveChanges();
			return activity;
		}

		public Activity Get(int id)
		{
			return _context.Activities.FirstOrDefault(a => a.Id == id);
		}

		public IEnumerable<Activity> GetAll()
		{
			return _context.Activities.OrderBy(a => a.Name);
		}

		public Activity Update(Activity activity)
		{
			_context.Attach(activity).State = 
				EntityState.Modified;
			_context.SaveChanges();
			return activity;

		}
	}
}
