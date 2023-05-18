using Exercise3;
using SomeLegacyLibrary;

namespace Exercise3Test
{
    public class PikachooTests
    {
        [SetUp]
        

        [Test]
        public void VerifySpeakMethod()
        {
            Pikachoo pikachoo = new Pikachoo("Tuiki");
            AnimalAdaptor pikachooAdaptee = new AnimalAdaptor(pikachoo);
              var pikachooSpeak=pikachooAdaptee.Speak();

            Console.WriteLine(pikachooSpeak);
            Assert.AreEqual(pikachooSpeak,$"{pikachooAdaptee.AnimalName} says Pika-choo!");
        }

        


    }
}