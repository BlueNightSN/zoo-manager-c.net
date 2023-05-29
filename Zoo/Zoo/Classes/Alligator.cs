using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Serializable]
    internal class Alligator:Reptiles
    {
        public Alligator(int Legs = 4, bool Venom = false, string Name = "No-name", string Type = "Alligator", int Age = 0, string Food = "Fish and mammals", string Gender = "unknown") : base(Legs, Venom, Name, Type, Age, Food, Gender) { }
        public override string fun_fact()
        {
            return string.Format("An alligator can live for 6 month without food!");
        }
    }
   
}
