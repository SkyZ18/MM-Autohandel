﻿using Npgsql.Replication.PgOutput.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Autohandel
{
    class Car
    {
        private string model;
        private string brand;
        private int whp;
        private int km;

        public Car(string brand, string model, int whp) {
            this.brand = brand;
            this.model = model;
            this.whp = whp;
        }

        public Car(string brand, string model, int whp, int km)
        {
            this.brand = brand;
            this.model = model;
            this.whp = whp;
            this.km = km;
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
    }
}