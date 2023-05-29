using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data;

namespace Zoo
{
    [Serializable]

    public class Class_Animal
    {
        public string _name { get; set; }
        public string _type { get; set; }
        public decimal _age { get; set; }
        public string _food { get; set; }
        public string _gender { get; set; }
        public Class_Animal(string Name = "No-name", string Type = "unknown", int Age = 0, string Food = "No spesific food", string Gender = "unknown")
        {
            _name = Name;
            _type = Type;
            _age = Age;
            _food = Food;

            if (Gender == "Male" || Gender == "male" || Gender == "MALE")
                _gender = Gender;
            else if (Gender == "Female" || Gender == "female" || Gender == "FEMALE")
                _gender = Gender;
            else
                _gender = "unknown";

        }
        public virtual string fun_fact()
        {
            return string.Format("A goldfish can't ever close its eyes because it has no eyelids!");
        }
    }

}

