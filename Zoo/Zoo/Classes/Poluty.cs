using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Serializable]
    class Poultry :Class_Animal
    {
        int _len_wings { get; set; }
        bool _is_fly { get; set; }


        public Poultry(int Len, bool Fly = false, string Name = "No-name", string Type = "Polutry", int Age = 0, string Food = "No spesific food", string Gender = "unknown") : base(Name, Type, Age, Food, Gender)
        {
            _len_wings = Len;
            _is_fly = Fly;

        }
        public override string fun_fact()
        {
            return string.Format("The ostrich egg is the largest in the world!");
        }

    }
}
