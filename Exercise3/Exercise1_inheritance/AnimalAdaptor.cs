using SomeLegacyLibrary;

namespace Exercise3
{
    public class AnimalAdaptor : Animal
    {
      //  private Pikachoo _pikachoo;
       private IPokemon _pokemon;

        public AnimalAdaptor(IPokemon pokemon)
        {
           // _pikachoo = pikachoo;
           AnimalName = pokemon.Name;
         _pokemon = pokemon;
        }

        
        public override string Speak()
        {
            return _pokemon.LegacySpeakMethod();
        }

        
    }
}
