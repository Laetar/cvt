using Organizer.Server.DAL.Repositories.Interfaces;
using Organizer.Server.Models.DataBase.Entities.Interfaces;
using Organizer.Server.Models.Filters;
using Organizer.Server.Models.Filters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqKit;
using Organizer.Server.DAL.Services.Interfaces;
using Organizer.Server.DAL.Attributes;

namespace Organizer.Server.DAL.Services
{
    [AdditionalService]
    public class FilterService : IFilterService
    {
        private readonly IEnumerable<IRepository<IEntity>> repositories;

        public FilterService(IEnumerable<IRepository<IEntity>> repositories)
        {
            this.repositories = repositories;
        }

        public IEnumerable<IEntity> ExecuteFilter(IFilterContainer filter)
        {
            var result = new List<IEntity>();

            foreach(IRepository<IEntity> repo in repositories)
            {
                result.AddRange(repo.GetList(filter.GetPredicate));
            }

            return result;
        }

       
    }
}
