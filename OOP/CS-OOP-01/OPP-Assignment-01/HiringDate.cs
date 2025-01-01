using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Assignment_01
{
    internal class HiringDate
    {
		private int day;
		private int month;
		private int year;


		public int Year
		{
			get { return year; }

			set 
			{
                if (year < 1)
                    throw new ArgumentException("Year must be a positive value.");
                else 
					year = value; 
			}
		}


		public int Month
		{
			get { return month; }

			set 
			{
                if (month < 1 || month > 12)
                    throw new ArgumentException("Month must be between 1 and 12.");
                else 
					month = value; 
			}
		}


		public int Day
		{
			get { return day; }

			set 
			{
                if (day < 1 || day > 31)
                    throw new ArgumentException("Day must be between 1 and 31.");
				else
					day = value;
			}
		}

		public HiringDate(int d, int m, int y)
		{
			day = d;
			month = m;
			year = y;
		}


        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }





    }
}
