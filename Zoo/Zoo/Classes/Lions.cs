using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lions:Mammals
    {
        bool _is_mane { get; set; }
       public  decimal _roar_volume { get; set; }

        public Lions(int Roar=0, bool IsFur = true, string Name = "No-name", string Type = "Lion", int Age = 0, string Food = "Meat", string Gender = "unknown") : base(IsFur, Name, Type, Age, Food, Gender)
        {
            if (Gender == "Male" || Gender == "male" || Gender == "MALE")
                _is_mane = true;
            else
                _is_mane = false;

            _roar_volume = Roar;
        }
        public override string fun_fact()
        {
            return string.Format("A lion's roar can be heard up to a distance of 8 kilometers!");
        }
    }
}
