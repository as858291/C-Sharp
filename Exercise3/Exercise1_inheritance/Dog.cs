using Exercise3;

namespace Exercise3
{
    public class Dog: Animal
    {
        public Dog(string name)
        {
            AnimalName = name;
            Sound = "Woof Woof";
        }

        public string DogBarkingReason(string dogAction)
        {
          //  List<string> barkingReasonList = new List<string> { "greeting barking", "Frustration-Induced Barking" };

           
            var reason = "";
            switch (dogAction)
            {
                case "greeting barking":

                   return reason = "Welcoming the owner";


                case "Frustration-Induced Barking":

                    return reason = "Dog is hungry";

                default:
                    Console.WriteLine("Reason unknown");
                    return null;
                    break;

            }
            


        }

    }
}
