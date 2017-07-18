using System;
using System.Text.RegularExpressions;

namespace ChartNQA
{
    class MyTime
    {
        public string DateTo = string.Empty;
        public string DateFrom = string.Empty;
        public string DateRead = string.Empty;

        public MyTime()
        {

        }

        public bool Result()
        {
            DateTime dateFrom;
            DateTime dateTo;
            DateTime dateRead;
            
            dateFrom = Parse(DateFrom) ? DateTime.Parse(DateFrom) : DateTime.Parse("01/01/1970 00:00");
            dateTo = Parse(DateTo) ? DateTime.Parse(DateTo) : DateTime.Parse("31/12/2099 23:59");
            dateRead = DateTime.Parse(DateRead);
            if (dateFrom.Date <= dateRead.Date && dateTo.Date >= dateRead.Date)
                return (true);
            return (false);
        }

        private bool Parse(string s)
        {
            Regex myRegex = new Regex(@"\d+\/\d+\/\d+ \d+:\d+");
            Match ma = myRegex.Match(s);
            if (ma.Success)
                return (true);
            return (false);
        }
    }
}
