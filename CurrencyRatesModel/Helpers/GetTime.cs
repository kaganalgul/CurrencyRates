using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRatesModel.Helpers
{
    public static class GetTime
    {
        public static string GetSuitableTimeForUrl(this DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();

            if (Convert.ToInt32(day) <= 9)
            {
                day = $"0{day}";
            }

            if (Convert.ToInt32(month) <= 9)
            {
                month = $"0{month}";
            }

            return $"{year}-{month}-{day}";
        }
    }
}
