using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLegacyLibrary
{
    public class Eevee :IPokemon
    {
        public Eevee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public string LegacySpeakMethod()
        {
            return $"{Name} says Eh-Veh,Eh-Vay Eh-Voi!";
        }


    }
}
