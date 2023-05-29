using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Serializable]
    public class Mammals : Class_Animal
    {
        bool _is_fur { get; set; }

        public Mammals(bool IsFur = false, string Name = "No-name", string Type = "Mammal", int Age = 0, string Food = "No spesific food", string Gender = "unknown") : base(Name, Type, Age, Food, Gender)
        { 
            _is_fur = IsFur;
        }
        public override string fun_fact()
        {
            return string.Format("A giraffe's neck has only 7 vertebrates even though its neck is so long!");
        }
    }
}
