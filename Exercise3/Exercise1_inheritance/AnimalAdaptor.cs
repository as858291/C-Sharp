using SomeLegacyLibrary;

namespace Exercise3
{
    public class AnimalAdaptor : Animal
    {
        private Pikachoo _pikachoo;
      //  private IPokemon _pokemnon;

        public AnimalAdaptor(Pikachoo pikachoo)
        {
            _pikachoo = pikachoo;
            AnimalName = pikachoo.Name;
           // _pokemnon = pokemnon;
        }

        
        public override string Speak()
        {
            return _pikachoo.LegacySpeakMethod();
        }

        
    }
}
