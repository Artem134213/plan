using IU.PlanManeger.Dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.Extensions
{
    public class Task : Event
    {
        public virtual string Result { get; set; }

        /// <summary>
        /// Процент выполнения
        /// </summary>
        public virtual double PercentComliete { get; set; }
    }
}
