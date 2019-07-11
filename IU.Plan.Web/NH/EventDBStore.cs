using IU.PlanManeger.Dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IU.Plan.Web.NH
{
    /// <summary>
    /// Хранилище событий <see cref="Event"/>
    /// </summary>
    public class EventDBStore<T> : BaseDBStore<T>
        where T : Event
    {
        public override IEnumerable<T> Entities =>
            base.Entities.Where(ent => ent.LifeStatus == EntityLifeStatus.Active);

        public override void Delete(Guid uid)
        {
            var evt = Get(uid);
            if (evt != null)
            {
                evt.LifeStatus = EntityLifeStatus.Deleted;
                Update(evt);
            }
        }
    }
}