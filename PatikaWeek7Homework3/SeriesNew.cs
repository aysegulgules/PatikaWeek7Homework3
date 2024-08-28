using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek7Homework3
{
    internal class SeriesNew:IComparable<SeriesNew>
    {
        public string SeriesName { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public int CompareTo(SeriesNew? other)
        {
            
            throw new NotImplementedException();
        }
    }
}
