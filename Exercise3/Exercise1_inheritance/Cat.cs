using Exercise3;

namespace Exercise3
{
    public class Cat :Animal
    {



        public Cat(string name)
        {
            AnimalName = name;
            Sound = "Meow Meow";
        }


        public string MeowInterpretation(string? meowSound)
        {


            string result = String.Empty;
            if (meowSound != null)
                switch (meowSound.ToLower())
                {
                    case "soundless meow":
                    {
                        result = "I’m hungry and/or thirsty.";
                        Console.WriteLine($"{meowSound} means {result}");
                        break;
                    }

                    case "low drawn-out meow":
                    {
                        result = "I’m booooored.";
                        Console.WriteLine($"{meowSound} means {result}");
                        break;
                    }
                    case "short high-pitched meows:":
                    {
                        result = "Yay for a “welcome home”";
                        Console.WriteLine($"{meowSound} means {result}");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine($"Can't interpret the {meowSound}");
                        break;
                    }
                }

            return result;
        }

    }
}

