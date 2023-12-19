using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA_Sorokina_program
{
    public class Necklace
    {
        private List<IGemstone> stones = new List<IGemstone>();

        public List<IGemstone> gemstones;

        public Necklace()
        {
            throw new NotImplementedException();
        }

        public void AddStone(IGemstone stone)
        {
            throw new NotImplementedException();
        }

        public bool Contains(IGemstone stone)
        {
            throw new NotImplementedException();
        }

        public void RemoveStone(IGemstone stone)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalValue()
        {
            throw new NotImplementedException();
        }

        public double GetTotalWeight()
        {
            throw new NotImplementedException();
        }

        public void SortByValue()
        {
            throw new NotImplementedException();
        }

        public static void DeleteStone(Necklace necklace, IGemstone stone)
        {
            // Метод для видалення каменю з намиста
            throw new NotImplementedException();
        }

        public static List<IGemstone> FindStonesByColor(Necklace necklace, string color)
        {
            // Метод для пошуку каменів за кольором
            throw new NotImplementedException();
        }

        public List<IGemstone> GetStones()
        {
            //return stones;
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
