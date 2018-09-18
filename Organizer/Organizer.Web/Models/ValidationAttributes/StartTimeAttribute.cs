using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Organizer.Web.Models.ValidationAttributes
{
    public class StartTimeAttribute : RangeAttribute
    {
        public StartTimeAttribute()
            : base(typeof(DateTime),
                DateTime.Now.ToString().ToString(),
                DateTime.Now.AddYears(4).ToString())
        {}
    }
}
