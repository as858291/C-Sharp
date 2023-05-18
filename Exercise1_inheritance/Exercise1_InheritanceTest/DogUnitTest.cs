using Exercise1_inheritance;

namespace Exercise1_InheritanceTest
{
    public class DogTests
    {
        [SetUp]
        

        [Test]
        public void VerifySpeakMethod()
        {
            Dog dog = new Dog("Max");
            dog.Speak(dog.AnimalName,dog.Sound);
            Assert.That(dog.Sound, Is.EqualTo("Woof Woof"));
        }


        [Test]
        public void VerifyDogBarkingReason()
        {
            Dog dog = new Dog("Shera");

            var dogBarkingReason = dog.DogBarkingReason("Frustration-Induced Barking");
            Assert.That(dogBarkingReason, Is.EqualTo("Doeg is hungry"));
        }

    }
}