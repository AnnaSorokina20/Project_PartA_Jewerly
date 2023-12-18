using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA_Sorokina_program
{
    public class PreciousStone : Stone
    {
        public int Clarity { get; private set; }

        public PreciousStone(string name, double caratWeight, decimal price, string color, int clarity)
            : base(name, caratWeight, price, color)
        {
            throw new NotImplementedException();
        }

        public override string GetName() => throw new NotImplementedException();
        public override double GetWeight() => throw new NotImplementedException();
        public override decimal GetValue() => throw new NotImplementedException();
        public override string GetColor() => throw new NotImplementedException();
        public override string GetDetails() => throw new NotImplementedException();
    }

}
