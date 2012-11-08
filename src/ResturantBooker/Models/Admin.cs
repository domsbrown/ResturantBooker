using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ResturantBooker.Models.Enum;

namespace ResturantBooker.Models
{
	public class Admin
	{
		[Required(ErrorMessage = "Please enter the item you wish to add")]
		[Display(Name = "Add Item")]
		public string AddItem		{ get; set; }

		[Required(ErrorMessage = "Please enter the price of the item you wish to add")]
		public decimal Price		{ get; set; }
	}
}