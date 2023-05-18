using Exercise3;

namespace Exercise3Test
{
    public class CatTests
    {
        [SetUp]
        

        [Test]
        public void VerifySpeakMethod()
        {
            Cat cat = new Cat("Ivana");
            var catSound=cat.Speak();
            Console.WriteLine(catSound);
            Assert.That(cat.Sound, Is.EqualTo("Meow Meow"));
        }


        [Test]
        public void VerifyCatSoundInterpretation()
        {
            Cat cat = new Cat("molly");
           var catInterpretation = cat.MeowInterpretation("soundless meow");
            Assert.That(catInterpretation, Is.EqualTo("I’m hungry and/or thirsty."));
        }

    }
}