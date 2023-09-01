namespace PokemonViaTDD
{
     class Pikachu
     {
         public int _level;
         public int expPoint;

       public  Pikachu ()
        {
            _level = 1;
        }


       public int Level
       {
           get => _level;
       }

       public int LevelUp()
       {
           return _level++;
       }

        public AttackType Attack()
       {
           return new AttackType("Thunderstrike", 10);
       }
    }






}

    

