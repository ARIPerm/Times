using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times
{
    class TimeArray
    {
        Time[] TimeArr;
        int size=0;

        Random rnd = new Random();
        Time time = new Time();
        public TimeArray()
        {
            size++;
            TimeArr[size - 1] = time;
        }

        public TimeArray(int Hours,int Minutes)
        {
            time = new Time(Hours, Minutes);
            size++;
            TimeArr[size - 1] = time;
        }

        public Time GetItem(int index)
        {
            return TimeArr[index-1];
        }

        public int Average()
        {
            int amount = 0;
            for (int i =0; i<size;i++)
            {
                amount += time.GetMin();
            }
            return amount /= size;
        }
    }
}
