using Exercise1_inheritance;

namespace Exercise1_InheritanceTest
{
    public class CatTests
    {
        [SetUp]
        

        [Test]
        public void VerifySpeakMethod()
        {
            Cat cat = new Cat("Ivana");
            cat.Speak(cat.AnimalName,cat.Sound);
            Assert.That(cat.Sound, Is.EqualTo("Meow Meow"));
        }


        [Test]
        public void VerifyCatSoundInterpretation()
        {
            Cat cat = new Cat("molly");
            cat.Speak(cat.AnimalName, cat.Sound);
           var catInterpretation = cat.MeowInterpretation("soundless meow");
            Assert.That(catInterpretation, Is.EqualTo("I’m hungry and/or thirsty."));
        }

    }
}