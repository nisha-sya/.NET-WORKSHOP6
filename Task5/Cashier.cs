using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Cashier
    {
        public string name;
        public string description;
        public double sale;

        public Cashier(string name, string description, double sale)
        {
            this.name = name;
            this.description = description;
            this.sale = sale;
        }


    }
}