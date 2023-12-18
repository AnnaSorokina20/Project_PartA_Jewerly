using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA_Sorokina_program
{
    public interface IGemstone
    {
        string GetName();
        double GetWeight();
        decimal GetValue();
        string GetColor();
        string GetDetails();
    }
}
