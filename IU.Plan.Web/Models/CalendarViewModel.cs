using System;
using System.Collections.Generic;
using IU.PlanManeger.Dll.Models;

namespace IU.Plan.Web.Models
{

    public static class DayOfWeekExtension
    {
        /// <summary>
        /// Возвращает числовой код дня от 1 до 7
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        public static int ToInt(this DayOfWeek dayOfWeek)
        {
            return dayOfWeek == 0 ? 7 : (int)dayOfWeek - 1;
        }
    }

    public class CalendarViewModel
    {
        public CalendarViewModel()
        {
            Events = new List<Event>();
        }

        /// <summary>
        /// События
        /// </summary>
        public IEnumerable<Event> Events { get; set; }

        /// <summary>
        /// Количество ячеек
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Количество колонок
        /// </summary>
        public int ColCount { get; set; }

        /// <summary>
        /// Количество строк
        /// </summary>
        public int RowCount
        {
            get
            {
                var totalCells = Limit + StartDay.DayOfWeek.ToInt();

                return (int)Math.Ceiling(totalCells * 1d / ColCount);
            }
        }

        /// <summary>
        /// С какого дня недели начинается месяц
        /// </summary>
        public DateTime StartDay { get; set; }
    }
}