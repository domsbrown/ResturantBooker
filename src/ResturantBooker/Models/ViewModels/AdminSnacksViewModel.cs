﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResturantBooker.DataAccess;

namespace ResturantBooker.Models.ViewModels
{
	public class AdminSnacksViewModel : Admin
	{
		public int				RecordCount	{ get; set; }
		public int				PageSize	{ get; private set; }
		public int				CurrentPage	{ get; private set; }
		public List<Snack>		Snacks		{ get; set; }

		public List<int> GetPages()
		{
			return Enumerable.Range(1, (int)Math.Ceiling(RecordCount / Convert.ToDouble(PageSize))).ToList();
		}

		public AdminSnacksViewModel(int currentPage, int pageSize)
		{
			this.CurrentPage = currentPage;
			this.PageSize = pageSize;
		}

		public int GetSkipCount()
		{
			return(CurrentPage - 1)*PageSize;
		}

		public int GetTakeCount()
		{
			return PageSize;
		}
	}
}