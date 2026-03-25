using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Methods for the calculator
        // Method for checking user input (make sure it is int)
        // static string user_expected_input()
        // {
            
        // }

        // // Method for Addition
        // static int Addition_result()
        // {
            
        // }
        // // Method for Subtraction
        // static int Subtraction_result()
        // {
            
        // }

        // // Method for Multiplication
        // static int Multiplication_result()
        // {
            
        // }

        // // Method for Division
        // static int Division_result()
        // {
            
        // }

        while(true)
        {
            int initial_value = 0;
            int second_value = 0;
            int saved_value = 0;

            Console.WriteLine("Welcome to Simple Calculator");
            Console.WriteLine("Choose initial value");
            if (!int.TryParse(Console.ReadLine(), out initial_value))
            {
                Console.WriteLine("Wrong initial value type (not int). Please input a number");
            }

            Console.WriteLine("Choose the operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Choose option: ");
            string user_input = Console.ReadLine();

            Console.WriteLine("Choose the next value to be operated: ");
            if (!int.TryParse(Console.ReadLine(), out second_value))
            {
                Console.WriteLine("Wrong Second Value type (not int). Please input the correct number.");
            }

            if (user_input == "1")
            {   
                saved_value = initial_value + second_value;
                  
            }

            else if (user_input == "2")
            {
                saved_value = initial_value - second_value;
                
            }
            
            else if (user_input == "3")
            {
                saved_value = initial_value * second_value;
                
            }

            else if (user_input == "4")
            {
                saved_value = initial_value / second_value;
                
            }

            else if (user_input == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine("Wrong option choose. Please choose another one");
            }

        }
    }
}
