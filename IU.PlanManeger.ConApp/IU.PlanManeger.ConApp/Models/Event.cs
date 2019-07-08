using System;
using System.Collections.Generic;

namespace IU.PlanManager.ConApp.Models
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

        public override string ToString()
        {
            var fields = new List<string>() { StartDate?.ToShortDateString(), Title , Place};

            fields.RemoveAll(s => string.IsNullOrWhiteSpace(s));

            return string.Join(", ", fields);
        }
    }
}
