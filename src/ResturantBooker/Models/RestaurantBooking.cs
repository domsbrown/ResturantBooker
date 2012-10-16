using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ResturantBooker.Models.Enum;

namespace ResturantBooker.Models
{
	public class RestaurantBooking
	{
		[Required(ErrorMessage = "Please enter your name")]
		[Display(Name = "Name")]
		public string PersonName	{ get; set; }

		[Required(ErrorMessage = "Please select your meal")]
		public string Meal			{ get; set; }

		[Display(Name = "Extras")]
		public string ExtraOption	{ get; set; }

		[Required(ErrorMessage = "Please select your day")]
		public Day Day				{ get; set; }
	}
}