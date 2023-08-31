namespace PokemonViaTDD
{
     class Pikachu 
    {
        public int Level { get; }

       public  Pikachu ()
        {
            Level = 1;
        }

       public AttackType Attack()
       {
           return new AttackType("Thunderstrike", 10);
       }
    }






}

    

