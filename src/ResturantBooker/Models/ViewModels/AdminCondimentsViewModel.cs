using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResturantBooker.DataAccess;

namespace ResturantBooker.Models.ViewModels
{
	public class AdminCondimentsViewModel : Admin
	{
		public int		 RecordCount	{ get; set; }
		public int		 PageSize		{ get; private set; }
		public int		 CurrentPage	{ get; private set; }
		public List<Condiment> Condiments		{ get; set; }

		public List<int> GetPages()
		{
			return Enumerable.Range(1, (int)Math.Ceiling(RecordCount / Convert.ToDouble(PageSize))).ToList();
		}

		public AdminCondimentsViewModel(int currentPage, int pageSize)
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