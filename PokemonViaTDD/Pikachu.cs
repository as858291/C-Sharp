using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonViaTDD
{
     class Pikachu 
    {
       
public Attacktype Attack()
{
            return new Attacktype("Thunderstorm",10);
}

       
    }


     class Attacktype
     {
         public string Type { get; set; }
         public int Power { get; set; }
        public Attacktype(string type, int power)
         {
             Type=type;
             Power=power;

         }

     


    }

    
}
