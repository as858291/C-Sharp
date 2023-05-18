using Exercise1_inheritance;

namespace Exercise1_InheritanceTest
{
    public class AnimalManagerTests
    {
        [Test, Order(1)]
        public void AddAnimal()
        {
            AnimalManager animalManager= new AnimalManager();
            animalManager.AddAnimal("Cow");
            animalManager.AddAnimal("Horse");
            animalManager.AddAnimal("Goat");
            animalManager.DisplayAnimal();


        }

        [Test,Order(2)]
        public void RemoveAnimal()
        {
            AnimalManager animalManager = new AnimalManager();
            animalManager.AddAnimal("Pig");
            animalManager.AddAnimal("Lion");
            animalManager.AddAnimal("Tiger");
            animalManager.RemoveAnimal("Cow");
            animalManager.RemoveAnimal("Lion");
            animalManager.DisplayAnimal();

        }
    }
}