﻿using GoFarm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace GoFarm.DataAccess.Data.Repository.IRepository
{
	public interface IFrequencyRepository:IRepository<Frequency>
	{
		void Update(Frequency frequency);
		IEnumerable<SelectListItem> GetFrequencyListForDropDown();
	}
}
