using Exercise3;

namespace Exercise3Test
{
    public class DogTests
    {
        [SetUp]
        

        [Test]
        public void VerifySpeakMethod()
        {
            Dog dog = new Dog("Max");
            string dogSound=dog.Speak();
            Console.WriteLine(dogSound);
            Assert.That(dog.Sound, Is.EqualTo("Woof Woof"));
        }


        [Test]
        public void VerifyDogBarkingReason()
        {
            Dog dog = new Dog("Shera");

            var dogBarkingReason = dog.DogBarkingReason("Frustration-Induced Barking");
            Assert.That(dogBarkingReason, Is.EqualTo("Dog is hungry"));
        }

    }
}