using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Animal
    {

        public string AnimalName { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }
        public int leg { get; set; }

        public List<string> animalList = new List<string>();


        public virtual string Speak()
        {
            return $"{AnimalName} sound {Sound}";
        }

      



    }
}

