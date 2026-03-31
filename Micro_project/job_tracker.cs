using System;
using System.Collections.Generic;
using System.Linq;

class Jobs
{
    public string Company {get; set;}
    public string Position {get; set;}
    public string Status {get; set;}

    public Jobs (string applied_company, string applied_position, string job_status)
    {
        Company = applied_company;
        Position = applied_position;
        Status = job_status;
    }
}

class Program
{
    static void Main()
    {
        List<Jobs> Jobs_saved = new List<Jobs>();

        while (true)
        {
            Console.WriteLine("Welcome to Job Tracker.");
            Console.WriteLine("Select the options to proceed");
            Console.WriteLine("1. Add Job");
            Console.WriteLine("2. List Jobs");
            Console.WriteLine("3. Exit.");

            Console.Write("Selected option: ");
            string user_input = Console.ReadLine();

            if (user_input == "1")
            {
                // Add the details one by one based on the details in class Jobs
                // Save the user input to Jobs_saved
            }
            
            else if (user_input == "2")
            {
                // Logic to check if list = 0, return none
                // loop logic to display all the jobs in the Jobs_saved
            }

            else if (user_input == "3")
            {
                break;
            }

            else
            {
                Console.WriteLine("Wrong input. Please input from the given options.");
            }
        }
    }
}