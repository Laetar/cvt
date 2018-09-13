using Organizer.Server.Models.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organizer.Web.Models.CalendarViewModels
{
    public class FilterViewModel
    {
        public EntityType? Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
