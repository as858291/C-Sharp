using SomeLegacyLibrary;

namespace Exercise3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Dog dog = new Dog("Rocky");
        dog.Speak();


        AnimalManager am = new AnimalManager();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Add animal");
            string? animalname = Console.ReadLine();
            am.AddAnimal(animalname);


        }
        am.DisplayAnimal();

        Console.WriteLine("Remove animal");
        string? removeanimal = Console.ReadLine();
        am.RemoveAnimal(removeanimal);
        am.DisplayAnimal();

        Pikachoo pikachoo = new Pikachoo("Kristy");
        string pikachoospeak=pikachoo.LegacySpeakMethod();
        Console.WriteLine(pikachoospeak);


        AnimalAdaptor pikachoo1 = new AnimalAdaptor(pikachoo);
        var pikachoospeak1 = pikachoo1.Speak();
        Console.WriteLine(pikachoospeak1);
    }
}