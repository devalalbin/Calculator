using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(-1, -6, -7)]
        //  [InlineData(1, 2, 4)] fail test to check if it would detect
        public void AdditionTest(int numOne, int numTwo, int expected) //Test of the addition method in calculator class
        {
            //Arrange (prep things we need for test)        
            //int expected = 3;
            //Act (runs method)
            Calculator addTest = new Calculator(numOne, numTwo);
            //Assert (validate)
            Assert.Equal(expected, addTest.Addition());
        }
        [Theory]
        [InlineData(new int[] { 1, 2 }, 3)] //testing arrays
        [InlineData(new int[] { 1,2,3,4,5,6,7,8,9,10 }, 55)]
        [InlineData(new int[] { -10,-10 }, -20)]
        public void ArrayAdditionTest(int[] numArray, int expected) //Test of the addition method in calculator class
        {
            //Arrange (prep things we need for test)        
            //Act (runs method)
            Calculator addArrTest = new Calculator();
            //Assert (validate)
            Assert.Equal(expected, addArrTest.Addition(numArray));
        }



        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 10, 0)]
        [InlineData(-10, 6, -16)]
        [InlineData(10, -6, 16)]
        public void SubtractionTest(int numOne, int numTwo, int expected) //Test of the Subtraction method in calculator class
        {
            //Act (runs method)
            Calculator subTest = new Calculator(numOne, numTwo);
            //Assert (validate)
            Assert.Equal(expected, subTest.Subtraction());
        }

        [Theory]
        [InlineData(new int[] { 10, 2 }, 8)] //testing arrays (10-2 = 8?)
        [InlineData(new int[] { 100,10,10,10,10 }, 60)]// 100-10-10-10-10 = 60?
        [InlineData(new int[] { -10, -10 }, 0)] // -10 - - 10 = 0?
        public void ArraySubtractionTest(int[] numArray, int expected) //Test of the Subtraction method in calculator class with an array as input
        {
            //Act (runs method)
            Calculator subArrTest = new Calculator();
            //Assert (validate)
            Assert.Equal(expected, subArrTest.Subtraction(numArray)); //testimg the overloaded subtraction method
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(10, 10, 100)]
        [InlineData(-10, 2, -20)]
        [InlineData(4, 4, 16)]
        public void MultiplicationTest(int numOne, int numTwo, int expected) //Test of the Multiplication method in calculator class
        {

            //Act (runs method)
            Calculator multTest = new Calculator(numOne, numTwo);

            //Assert (validate)
            Assert.Equal(expected, multTest.Multiplication());
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(1, 2, 0.5)]
        [InlineData(0, 3, 0)]
        [InlineData(5, 2, 2.5)]
        [InlineData(5, 0, 0)] // trying to divide by zero should fail
        public void DivisionTest(int numOne, int numTwo, double expected) //Test of the Multiplication method in calculator class
        {
            //Act (runs method)
            Calculator divTest = new Calculator(numOne, numTwo);
            //Assert (validate)
            Assert.Equal(expected, divTest.Division());
        }
    }
}
