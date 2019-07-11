using IU.Plan.Web.NH;
using IU.PlanManeger.Dll;
using IU.PlanManeger.Dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IU.Plan.Web.Controllers
{
    public class SearchController : Controller
    {
        private IStore<Event> store = new EventDBStore<Event>();

        [HttpPost]
        public ActionResult Filter(string searchRequest)
        {
            var result = store.Entities.Where(ent =>

                ent.Title.Contains(searchRequest) ||

                ent.Description.Contains(searchRequest)

                );

            return PartialView("List", result);
        }
    }
}