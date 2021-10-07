using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        //Fields
        int firstNumber; 
        public int FirstNumber
        { //property of firstnumber
            get { return firstNumber;} 
            set { firstNumber = value; }
        } 

        int secondNumber;
        public int SecondNumber
        { //property of secondNumber
            get { return secondNumber; }
            set { secondNumber = value; }
        }

        public int result;
        public int Result { get { return result; } }
        public int[] numArray;

        public Calculator() //Constructor
        {
            //start values
            this.firstNumber = 0;
            this.secondNumber = 0;
            this.result = 0;
            this.numArray = new int[] { 1, 2, 3 };

        }
        public Calculator(int firstNumber, int secondNumber) //Constructor with in two numbers as parameters
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
       
        public Calculator(int[] numArray) //Constructor with array inparameter
        {
            this.numArray = numArray;
        }
       

        //Methods
        public int Addition() //add togehter two values
        {
            result = firstNumber + secondNumber; //adding first + second = result
            return result;
        }

        public int Addition(int[] numArray) // Overloaded addition method (add togehter every value in the number array as an int)
        {
            this.numArray = numArray;
            int result = 0; // starting value of result
            for (int i = 0; i < numArray.Length; i++)
            {
                result = result + numArray[i];//sum upp every number of the array
            }
            return result;
        }

        public int Subtraction() //takes 2 values and subtracts then second value from the first
        {
            result = firstNumber - secondNumber; // subtraction
            return result;
        }

        public int Subtraction(int[] numArray) //Overloaded Subtraction method
        {
            this.numArray = numArray;
            int result = numArray[0]; //staring value to subtract from
            
            for (int i = 1; i < numArray.Length; i++)
            {
                result = result - numArray[i];//sum upp every number of the array
            }
            return result;
        }

        public int Multiplication() //takes 2 values and multiplies them 
        {
            result = firstNumber * secondNumber;
            return result;
        }

        public decimal Division() //divison function that takes 2 values and divides them
        {
            
            decimal dResult; //decimal instead of double cause of DivideByZeroException could not handle double
            int firstNum = this.firstNumber;
            int secondNum = this.secondNumber;
           
            try
            {
                dResult = (decimal)firstNum / secondNum;
                return dResult;
            }
            catch (DivideByZeroException e)
            {
                throw new ArgumentException("Cannot divide by zero!");
  
            }  
        }
    }


    
}
