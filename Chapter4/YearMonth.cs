using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }


        public YearMonth(int year, int month)
        {
            this.Year = year;
            this.Month = month;
        }

    }
}
