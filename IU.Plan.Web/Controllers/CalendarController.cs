using System;
using System.Linq;
using System.Web.Mvc;
using IU.Plan.Web.Models;
using IU.Plan.Web.NH;
using IU.PlanManager.Extensions;
using IU.PlanManeger.Dll;
using IU.PlanManeger.Dll.Models;
using IU.PlanManeger.Extensions;

namespace IU.Plan.Web.Controllers
{
    public class CalendarController : Controller
    {
        private IStore<Event> eventStore = new EventDBStore<Event>();

        private IStore<Activity> activityStore = new EventDBStore<Activity>();

        // GET: Calendar
        public ActionResult Index(DateTime yearMonthDay)
        {
            var today = DateTime.Today;

            var startMonth = yearMonthDay;
            var endMonth = startMonth.AddMonths(1);

            var events = eventStore.Entities.Where(evt =>
                   evt.StartDate >= startMonth && evt.StartDate < endMonth
                ).ToList();

            var model = new CalendarViewModel
            {
                Events = events,
                Limit = DateTime.DaysInMonth(yearMonthDay.Year, yearMonthDay.Month),
                ColCount = 7,
                StartDay = startMonth
            };

            return View(model);
        }
    }
}