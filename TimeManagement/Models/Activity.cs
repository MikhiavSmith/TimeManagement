using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeManagement.Models
{
    public class Activity
    {
		public int Id { get; set; }

		[Display(Name= "Activity Name")]
		[Required, MaxLength(80)]
		public string Name { get; set; }
		public CategoryType Category { get; set; }
	}
}
