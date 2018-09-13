using Organizer.Server.Models.DataBase.Entities.Interfaces;
using Organizer.Server.Models.Filters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.DAL.Services.Interfaces
{
    public interface IFilterService
    {
        IEnumerable<IEntity> ExecuteFilter(IFilterContainer typeFilter);
    }
}
