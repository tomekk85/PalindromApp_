using NUnit.Framework;
using PalindromApp;

namespace PalindromApp.UnitTests
{
    [TestFixture]
    public class PalindromTests
    {
       

        [Test]
        public void IsPalindrom_inputPalindromOneWord_ReturnsTrue()
        {
            //Arrange
            var palindrom = new Palindrom("kajak");
            //Act
            var result = palindrom.IsPalindrom();
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrom_inputPalindromOneWordDiffCase_ReturnsTrue()
        {
            //Arrange
            var palindrom = new Palindrom("kajaK");
            //Act
            var result = palindrom.IsPalindrom();
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrom_inputNotPalindromOneWord_ReturnsFalse()
        {
            //Arrange
            var palindrom = new Palindrom("kojak");
            //Act
            var result = palindrom.IsPalindrom();
            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrom_inputPalindromMultipleWords_ReturnsTrue()
        {
            //Arrange
            var palindrom = new Palindrom("koby³a ma ma³y bok");
            //Act
            var result = palindrom.IsPalindrom();
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrom_inputNotPalindromMultipleWords_ReturnsFalse()
        {
            //Arrange
            var palindrom = new Palindrom("Ala ma kota");
            //Act
            var result = palindrom.IsPalindrom();
            //Assert
            Assert.IsFalse(result);
        }

    }
}