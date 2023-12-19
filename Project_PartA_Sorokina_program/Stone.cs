using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA_Sorokina_program
{
    public abstract class Stone : IGemstone
    {
        public string Name { get; protected set; }
        public double CaratWeight { get; protected set; }
        public decimal Price { get; protected set; }
        public string Color { get; protected set; }

        protected Stone(string name, double caratWeight, decimal price, string color)
        {
            throw new NotImplementedException();
        }

        public abstract string GetName();
        public abstract double GetWeight();
        public abstract decimal GetValue();
        public abstract string GetColor();
        public abstract string GetDetails();
    }



}

