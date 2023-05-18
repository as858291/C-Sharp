namespace Exercise3
{
    public class AnimalManager:Animal
    {
        public void AddAnimal(string? name)
        {
            animalList.Add(name);
        }

        public void DisplayAnimal()
        {
            foreach (string? animal in animalList)
            {
                Console.WriteLine(animal);
            }
        }

        public void RemoveAnimal(string? name)
        {
            if (!animalList.Contains(name))
                Console.WriteLine($"{name} Doesn't exist in the zoo");

            else
              animalList.Remove(name);

        }
    }
}
