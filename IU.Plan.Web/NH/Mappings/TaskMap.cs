using FluentNHibernate.Mapping;
using IU.PlanManeger.Extensions;

namespace IU.Plan.Web.NH.Mappings
{
    public class TaskMap : SubclassMap<Task>
    {
        public TaskMap()
        {
            Map(act => act.Result);
            Map(act => act.PercentComliete);
        }
    }
}