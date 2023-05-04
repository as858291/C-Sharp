namespace Exercise1_inheritance
{
    internal class Dog: Animal
    {
        public Dog(string name)
        {
            AnimalName = name;
            Sound = "Woof Woof";
        }

        public void DogBarkingReason()
        {
            List<string> barkingReasonList = new List<string> { "greeting barking", "Frustration-Induced Barking" };

            foreach (var variable in barkingReasonList)
            {
                Console.WriteLine(variable);

            }


        }

    }
}
