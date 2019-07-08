using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IU.PlanManeger.Dll;
using IU.PlanManeger.Dll.Models;

namespace IU.Plan.Web.Controllers
{
    public class EventController : Controller
    {
        private IStore<Event> store = new EventFileStore();

        // GET: Event
        public ActionResult Details(Guid uid)
        {
            var evt = store.Get(uid);

            return View(evt);
        }

        public PartialViewResult MiniDetails(Guid uid)
        {
            var evt = store.Get(uid);

            return PartialView("Details", evt);
        }
    }
}