using Microsoft.AspNetCore.Mvc;
using Organizer.Server.DAL.Services.Interfaces;
using Organizer.Server.Models.Filters;
using Organizer.Web.Models.CalendarViewModels;

namespace Organizer.Web.Controllers
{
    public class CalendarController : Controller
    {
        private readonly IFilterService filterService;

        public CalendarController(IFilterService filterService)
        {
            this.filterService = filterService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetEntities(FilterViewModel filter)
        {
            var filterContainer = new FilterContainer();

            if (filter.Type != null)
                filterContainer.Add(x => x.Type == filter.Type);

            if(filter.StartDate != null)
                filterContainer.Add(x => x.StartTime > filter.StartDate);

            if (filter.EndDate != null)
                filterContainer.Add(x => x.StartTime < filter.EndDate);

            var result = filterService.ExecuteFilter(filterContainer);

            return new JsonResult(result);
        }
    }
}