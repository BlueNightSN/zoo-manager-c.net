using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Serializable]
    internal class Parrots : Poultry
    {
        bool _is_talk { get; set; }

        public Parrots(bool Talk, int Len = 0, bool Fly = true, string Name = "No-name", string Type = "Parrot", int Age = 0, string Food = "Fruits and vegetables", string Gender = "unknown") : base(Len, Fly, Name, Type, Age, Food, Gender)
        {
            _is_talk = Talk;
        }
        public override string fun_fact()
        {
            return string.Format("There are about 360 different species of parrots!");

        }
    }
}
