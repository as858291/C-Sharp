namespace Exercise1_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dog dog = new Dog("Rocky");
            dog.Speak(dog.AnimalName, dog.Sound);


            AnimalManager am = new AnimalManager();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Add animal");
                string animalname = Console.ReadLine();
                am.AddAnimal(animalname);


            }
            am.DisplayAnimal();

            Console.WriteLine("Remove animal");
            string removeanimal = Console.ReadLine();
            am.RemoveAnimal(removeanimal);
            am.DisplayAnimal();
        }
    }
}