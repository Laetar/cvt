using Organizer.Server.Models.DataBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Organizer.Server.Models.Filters.Interfaces
{
    public interface IFilterContainer
    {
        Expression<Func<IEntity, bool>> GetPredicate { get; }
        void Add(Expression<Func<IEntity, bool>> predicate);
    }
}
