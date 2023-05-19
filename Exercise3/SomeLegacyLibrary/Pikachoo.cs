﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLegacyLibrary
{
    public class Pikachoo:IPokemon
    {

        public Pikachoo(string name)
        {
            Name = name;
            
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public string LegacySpeakMethod()
        {
            return $"{Name} says Pika-choo!";
        }

      
    }
}
