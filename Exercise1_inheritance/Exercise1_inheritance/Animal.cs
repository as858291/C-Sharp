﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_inheritance
{
    public class Animal
    {

        public string AnimalName { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }
        public int leg { get; set; }

        public List<string> animalList = new List<string>();


        public void Speak(string animalName, string sound)
        {
            Console.WriteLine($"{animalName} sound {sound}");
        }

      



    }
}

