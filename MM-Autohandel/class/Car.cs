using Npgsql.Replication.PgOutput.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Autohandel
{
    public class Car
    {
        private string model;
        private string brand;
        private int whp;
        private int km;
        private string description;

        public Car(string brand, string model, int whp, string description)
        {
            this.brand = brand;
            this.model = model;
            this.whp = whp;
            this.description = description;
        }

        public Car(string brand, string model, int whp, int km, string description)
        {
            this.brand = brand;
            this.model = model;
            this.whp = whp;
            this.km = km;
            this.description = description;
        }

        public string getModel()
        {
            return model;
        }

        public string getBrand()
        {
            return brand;
        }

        public int getWhp() 
        {
            return whp;
        }

        public int getKm()
        {
            return km;
        }

        public string getDescription()
        {
            return description;
        }
    }
}
