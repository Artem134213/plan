using IU.PlanManeger.Dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.Extensions
{
    public class Meeting : Event
    {
        public virtual IEnumerable<User> Participants { get; set; }
    }
}
