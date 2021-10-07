using System;

namespace Calculator
{
     class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            Calculator calc = new Calculator();
            FunctionList();

            while (true)
            {                            
                Console.WriteLine("Please choose your function: (1-6) enter 0 to exit");
                userChoice = GetNumberFromUser(); //User picks what function they want to use           
                
                switch (userChoice)
                {      //switch case statement as the "menu" on what 
                    case 0: return; // exit
                    case 1: //Addition
                        Console.WriteLine("Please enter your first number"); 
                        calc.FirstNumber = GetNumberFromUser();
                        Console.WriteLine("Please enter your second number");
                        calc.SecondNumber = GetNumberFromUser();
                        Console.WriteLine(calc.FirstNumber + " + " + calc.SecondNumber + " = " + calc.Addition());
                        break;
                    case 2: //Subtraction
                        Console.WriteLine("Please enter your first number");
                        calc.FirstNumber = GetNumberFromUser();
                        Console.WriteLine("Please enter your second number");
                        calc.SecondNumber = GetNumberFromUser();
                        Console.WriteLine(calc.FirstNumber + " - " + calc.SecondNumber + " = " + calc.Subtraction());
                        break;
                    case 3: // Multiplication
                        Console.WriteLine("Please enter your first number");
                        calc.FirstNumber = GetNumberFromUser();
                        Console.WriteLine("Please enter your second number");
                        calc.SecondNumber = GetNumberFromUser();
                        Console.WriteLine(calc.FirstNumber + " * " + calc.SecondNumber + " = " + calc.Multiplication());
                        break;
                    case 4: //Division
                        Console.WriteLine("Please enter your first number");
                        calc.FirstNumber = GetNumberFromUser();
                        Console.WriteLine("Please enter your second number");
                        calc.SecondNumber = GetNumberFromUser();
                        while (calc.SecondNumber == 0)
                        {
                            Console.WriteLine("You are trying to divide by zero! Please enter another value"); //if they try to divide by zero give warning
                            calc.SecondNumber = GetNumberFromUser();
                        }
                        Console.WriteLine(calc.FirstNumber + " / " + calc.SecondNumber + " = " + calc.Division());
                        break;
                    case 5:
                        Console.WriteLine("Sum of your array is :" + calc.Addition(GetNumberArrayFromUser())); // Addition with array
                        break;
                    case 6:
                        Console.WriteLine("(First value minus rest of values in array) ");
                        Console.WriteLine("Value of your array is :" + calc.Subtraction(GetNumberArrayFromUser())); //Subtraction with array
                        break;
                    default:
                         Console.WriteLine("Please enter a valid number!");
                         break;
                }
                
            }
        }

        static void FunctionList()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Function list:");
            Console.WriteLine("1:Addition");
            Console.WriteLine("2:Subtraction");
            Console.WriteLine("3:Multiplication");
            Console.WriteLine("4:Division");
            Console.WriteLine("5:Addition with array");
            Console.WriteLine("6:Subtraction with array");

        }

        static int GetNumberFromUser() // Gets one number from the user
        {
            int userInput = 0;
            bool succeeded = false;
            while (!succeeded)
            {
                succeeded = int.TryParse(Console.ReadLine(), out userInput);// checking if the character is a valid number
                if (!succeeded)
                {
                    Console.WriteLine("You are trying to enter a non valid character, please try again!");
                }
            }
            //Console.WriteLine(succeeded);
            return userInput;
        }

        static int[] GetNumberArrayFromUser() //Gets an array of numbers from the user
        {
            bool succeeded = false;
            int arraySize = 0; // Size of array from user
            while (!succeeded)
            {
                while ( arraySize == 0) { //wait for user to enter a non empty array
                    Console.WriteLine("Write how many element you want in your array: "); 
                    succeeded = int.TryParse(Console.ReadLine(), out arraySize);// checking if the character is a valid number
                    if (arraySize == 0) 
                    {
                        Console.WriteLine("You are trying to enter empty array, please try again");
                    }
                }
                if (!succeeded)
                {
                    Console.WriteLine("You are trying to enter a non valid character, please try again!");
                }
            }
            int[] userInput = new int[arraySize];
            for (int i = 0; i < arraySize; i++) { // Fill array with (element) number of numbers
                Console.WriteLine("Numbers left to enter : "  + (arraySize-i));
                Console.WriteLine("Enter a new value into your array: ");
                userInput[i] = Convert.ToInt32(Console.ReadLine());               
            }    
            return userInput;
        }
    }
}