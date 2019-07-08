using System;
using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace IU.Plan.Web.Binding
{
    public class BrowserValueProvider : IValueProvider
    {
        private ControllerContext controllerContext { get; set; }

        public BrowserValueProvider(ControllerContext controllerContext)
        {
            this.controllerContext = controllerContext;
        }

        public bool ContainsPrefix(string prefix)
        {
            return string.Compare("yearmonthday", prefix, true) == 0;
        }

        public ValueProviderResult GetValue(string key)
        {
            var yearStr = "";// controllerContext.RequestContext.RouteData.Values["year"].ToString();
            var monthStr = "";// controllerContext.RequestContext.RouteData.Values["month"].ToString();
            var dayStr = "";// controllerContext.RequestContext.RouteData.Values["day"].ToString();

            if (!int.TryParse(yearStr, out int year))
            {
                year = DateTime.Today.Year;
            }

            if (!int.TryParse(monthStr, out int month))
            {
                month = DateTime.Today.Month;
            }

            if (!int.TryParse(dayStr, out int day))
            {
                day = 1;
            }

            var value = new DateTime(year, month, day);

            return ContainsPrefix(key)
                ? new ValueProviderResult(value, null, CultureInfo.InvariantCulture)
                : null;
        }
    }
}