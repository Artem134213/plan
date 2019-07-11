using IU.PlanManeger.Dll;
using IU.PlanManeger.Dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManager.Extensions
{
    /// <summary>
    /// Мероприятие
    /// </summary>
    public class Activity : Event
    {
        /// <summary>
        /// Бюджет
        /// </summary>
        public virtual Money Budget { get; set; }

        /// <summary>
        /// Количество участников
        /// </summary>
        public virtual int PeopleAmount { get; set; }
    }


    /// <summary>
    /// Деньги
    /// </summary>
    public class Money : IEntity
    {
        /// <inheritdoc/>
        public virtual Guid Uid { get; set; }

        /// <summary>
        /// Мероприятие
        /// </summary>
        public virtual Activity Activity { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        public virtual Currency Currency { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public virtual decimal Value { get; set; }
    }

    /// <summary>
    /// Валюта
    /// </summary>
    public enum Currency
    {
        RUB,
        EUR,
        USD,
        GBP,
        CNY
    }
}
