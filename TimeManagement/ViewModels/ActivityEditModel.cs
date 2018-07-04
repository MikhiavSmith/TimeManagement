using TimeManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace TimeManagement.ViewModels
{
	public class ActivityEditModel
    {
		[Required, MaxLength(80)]
		public string Name { get; set; }
		public CategoryType Category { get; set; }
	}
}
