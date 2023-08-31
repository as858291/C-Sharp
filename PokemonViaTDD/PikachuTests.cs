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
            Assert.AreEqual(result.Type, "Thunderstorm", "match");
        }
    }
}
