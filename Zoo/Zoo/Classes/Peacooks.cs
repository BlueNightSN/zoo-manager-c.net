using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Peacocks:Poultry
    {
       public decimal _range_tail { get; set; }

        public Peacocks(decimal Range=0, int Len = 0, bool Fly = false, string Name = "No-name", string Type = "Peacock", int Age = 0, string Food = "Insects", string Gender = "unknown") : base(Len, Fly, Name, Type, Age, Food, Gender)
        {
            _range_tail = Range;
        }
    }
}
