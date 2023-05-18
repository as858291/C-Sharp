using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3;
using SomeLegacyLibrary;

namespace Exercise3Test
{
    public class AnimalAdaptor : Animal
    {
        private Pikachoo _pikachoo;

        public AnimalAdaptor(Pikachoo pikachoo)
        {
            _pikachoo = pikachoo;
            AnimalName = pikachoo.Name;
        }

        
        public override string Speak()
        {
            return _pikachoo.LegacySpeakMethod();
        }


    }
}
