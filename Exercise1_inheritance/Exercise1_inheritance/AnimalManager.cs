namespace Exercise1_inheritance
{
    internal class AnimalManager:Animal
    {
        public void AddAnimal(string name)
        {
            animalList.Add(name);
        }

        public void DisplayAnimal()
        {
            foreach (string animal in animalList)
            {
                Console.WriteLine(animal);
            }
        }

        public void RemoveAnimal(string name)
        {
            animalList.Remove(name);
        }
    }
}
