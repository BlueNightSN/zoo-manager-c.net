using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Elephants :Mammals
    {
        public decimal _len_trunk { get; set; }

        public Elephants(decimal Len=0, bool IsFur = false, string Name = "No-name", string Type = "Elephant", int Age = 0, string Food = "Branches and leaves", string Gender = "unknown") : base(IsFur, Name, Type, Age, Food, Gender)
        {
            _len_trunk = Len;
        }
        public override string fun_fact()
        {
            return string.Format("The weight of an elephant at birth is 120 kilograms!");
        }
    }
}
