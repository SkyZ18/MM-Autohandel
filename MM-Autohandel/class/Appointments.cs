using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Autohandel
{
    internal class Appointments
    {
        private DateTime date;
        private DateTime time;
        private string place;
        private int userid;
        private Car car;

        public Appointments(DateTime date, DateTime time, string place, int userid, Car car) 
        {
            this.date = date;
            this.time = time;
            this.place = place;
            this.userid = userid;
            this.car = car;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public DateTime GetTime()
        {
            return time;
        }

        public string GetPlace()
        {
            return place;
        }

        public Car getCar()
        {
            return car;
        }
    }
}
