using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLegacyLibrary
{
   public interface IPokemon
    {

        string Name { get; set; }
        string? LegacySpeakMethod()
      {
          return null;
      }


    }
}
