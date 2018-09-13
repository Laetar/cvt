using LinqKit;
using Organizer.Server.Models.DataBase.Entities.Interfaces;
using Organizer.Server.Models.Filters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Organizer.Server.Models.Filters
{
    public class FilterContainer : IFilterContainer
    {
        private Expression<Func<IEntity, bool>> _predicate;

        public IEnumerable<IFilter> FilterList { get; set; }

        public FilterContainer()
        {
            _predicate = PredicateBuilder.New<IEntity>();
        }

        public FilterContainer(Expression<Func<IEntity, bool>> predicate)
        {
            _predicate = PredicateBuilder.New<IEntity>(predicate);
        }

        public void Add(Expression<Func<IEntity, bool>> predicate)
        {
            if (predicate != null)
                return;

            _predicate.And(predicate);
        }

    }
}
