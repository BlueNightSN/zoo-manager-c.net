using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Serializable]
    class Reptiles : Class_Animal
    {
        bool _is_venom { get; set; }
        int _legs { get; set; }

        public Reptiles(int Legs, bool Venom = false, string Name = "No-name", string Type = "Reptile", int Age = 0, string Food = "No spesific food", string Gender = "unknown") : base(Name, Type, Age, Food, Gender)
        {
            _is_venom = Venom;
            _legs = Legs;
        }
        public override string fun_fact()
        {
            return string.Format("The temperature of the soil where the reptiles lay their eggs determines how many will be male and how many will be female!");
        }
    }
}
