using Microsoft.EntityFrameworkCore;
using TimeManagement.Models;

namespace TimeManagement.Data
{
	public class TimeManagementDbContext : DbContext
    {
		public TimeManagementDbContext(DbContextOptions options)
			: base(options)
		{

		}

		public DbSet<Activity> Activities { get; set; }
    }
}
