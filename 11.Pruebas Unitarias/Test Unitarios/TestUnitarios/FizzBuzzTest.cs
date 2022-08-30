using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
namespace TestUnitarios
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
       public void FizzBuzz_CuandoElNumeroEsDivisiblePor3_DeveriaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";

            //Act 
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePor5_DeveriaRetornarBuzz()
        {
            //Arrange
            int numero = 5;
            string expected = "Buzz";

            //Act 
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePor3Y5_DeveriaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act 
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroNoEsDivisiblePor3Y5_DeveriaRetornarElnumero()
        {
            //Arrange
            int numero = 11;
            string expected = numero.ToString();

            //Act 
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
