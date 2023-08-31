using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonViaTDD;

namespace PokemonViaTDD
{
    [TestClass]
    public class PikachuTests
    {
        [TestMethod]
        public void Attack_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pikachu = new Pikachu();

            // Act
            var result = pikachu.Attack();

            // Assert
            Assert.AreEqual(result.Type, "Thunderstrike", "match");
        }

        [TestMethod]
        public void VerifyWhnePikachuIsSetLevel1()
        {
            // Arrange
            var pikachu = new Pikachu();
            var expectedLevel=1;

            // Act
            int actualLevel = pikachu.Level;

            // Assert
            Assert.AreEqual(actualLevel, expectedLevel, "Doenot match");
            
        }
    }
}
