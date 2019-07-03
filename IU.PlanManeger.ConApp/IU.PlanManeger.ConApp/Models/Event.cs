using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.ConApp.Models
{
    /// <summary>
    /// Событие
    /// </summary>
    public class Event : IEntity
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Event()
        {
            Uid = Guid.NewGuid();
        }
        /// <inheritdoc/>
        public Guid Uid { get; set; }

        /// <summary>
        /// Заголовок 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Окончание периода
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Место
        /// </summary>
        public string Place { get; set; }
    }
}
