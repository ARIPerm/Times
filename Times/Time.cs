using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times
{
    class Time
    {
        public static int IdTime = 0;
        private int mHours;
        public int Hours
        {
            get { return mHours; }
            set { mHours = value; }
        }
        private int mMinutes;
        public int Minutes
        {
            get { return mMinutes; }
            set { mMinutes = value; }
        }

        public int GetIdTime()
        {
            return IdTime;
        }

        public Time()
        {
            IdTime++;
            mMinutes = 0;
            mHours = 0;
        }

        public Time(int mHours, int mMinutes)
        {
            this.mHours = mHours;
            this.mMinutes = mMinutes;
            IdTime++;
        }

        public string GetTime()
        {
            return Convert.ToString(mHours) + ":" + Convert.ToString(mMinutes);
        }

        public int GetMin()
        {
            return mHours * 60 + mMinutes;
        }

        public static Time operator ++(Time a)
        {
            a.mMinutes+=1;
            return a;
        }

        public static Time operator --(Time a)
        {
            a.mMinutes -= 1;
            return a;
        }

        public static Time operator +(Time a, int value)
        {
            a.mMinutes += value;
            return a;
        }

        public static Time operator -(Time a, int value)
        {
            a.mMinutes -= value;
            return a;
        }
    }
}
