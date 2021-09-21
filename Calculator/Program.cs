using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice; 
            FunctionList();
            
            while (true)
            {



                Console.WriteLine("Please choose your function: (1-4) enter 0 to exit");
                userChoice = GetNumberFromUser(); //User picks what function they want to use

              
              
                {
                    switch (userChoice)
                    {      //switch case statement as the "menu" on what 
                        case 0: return; // exit
                        case 1:
                            Addition();
                            break;
                        case 2:
                            Subtraction();
                            break;
                        case 3:
                            Multiplication();
                            break;
                        case 4:
                            Division();
                            break;
                        default: Console.WriteLine("Please enter a valid number!");
                            break;





                    }
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
           

        }
        static void Addition() //add togehter two values
        {
            int a, b, res;
            Console.WriteLine("Please enter your first value: "); // user enter 2 values
            a = GetNumberFromUser();
            Console.WriteLine("Please enter your second value you want to add to the first: ");
            b = GetNumberFromUser();
            res = a + b; //adding a + b = result
            Console.WriteLine(a + " + " + b + " = " + res);
            return;
        }
        static void Subtraction() //takes 2 values and subtracts then second value from the first
        {
            int a, b, res;
            Console.WriteLine("Please enter your first value: "); // user enter 2 values
            a = GetNumberFromUser();
            Console.WriteLine("Please enter your second value that you want to subtract from the first: ");
            b = GetNumberFromUser();
            res = a - b; // subtraction
            Console.WriteLine(a + " - " + b + " = " + res);
            return;
        }
        static void Multiplication() //takes 2 values and multiplyes them 
        {
            int a, b, res;
            Console.WriteLine("Multiplication");
            Console.WriteLine("Please enter your first value: "); // user enter 2 values
            a = GetNumberFromUser();
            Console.WriteLine("Please enter your second value that you want to multiply with the first: ");
            b = GetNumberFromUser();
            res = a * b;
            Console.WriteLine(a + " * " + b + " = " + res);
            return;
        }
        static void Division() //divisin function that takes 2 values and divides them
        {
           double a,b,res;
           Console.WriteLine("Please enter your first value: "); // user enter 2 values
           a = GetNumberFromUser();
           Console.WriteLine("Please enter your second value: ");
           b = GetNumberFromUser();
           while (b == 0)
            {
                Console.WriteLine("You are trying to divide by zero! Please enter another value"); //if they try to divide by zero give warning
                b = GetNumberFromUser();
            }
           res = a / b; // a divided by b = result
           Console.WriteLine(a+" / "+b+" = "+res);
            return;
        }
        static int GetNumberFromUser()
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

    }
}
