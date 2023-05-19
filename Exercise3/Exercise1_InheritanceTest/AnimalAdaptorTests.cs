using Exercise3;
using NUnit.Framework;
using SomeLegacyLibrary;
using System.Xml.Linq;

namespace Exercise3Test
{
    [TestFixture]
    public class AnimalAdaptorTests
    {
        [Test]
        public void VerifyPikachooSound()
        {
            // Arrange
            Pikachoo pikachoo = new Pikachoo("Clara");
            var animalAdaptor = new AnimalAdaptor(pikachoo);


            // Act
            var result = animalAdaptor.Speak();
            Console.WriteLine(result);

            // Assert
            Assert.AreEqual(result, $"{animalAdaptor.AnimalName} says Pika-choo!");
        }

        [Test]
        public void VerifyEveeSound()
        {
            // Arrange
            Eevee evee = new Eevee("Kylie");
            var animalAdaptor = new AnimalAdaptor(evee);


            // Act
            var result = animalAdaptor.Speak();
            Console.WriteLine(result);

            // Assert
            Assert.AreEqual(result, $"{animalAdaptor.AnimalName} says Eh-Veh,Eh-Vay Eh-Voi!");
        }
    }
}
