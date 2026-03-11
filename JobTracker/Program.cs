// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Data;

enum JobStatus
{
    Applied,
    Interview,
    Rejected,
    Offer
}

class Job
{
    public int Id {get; set;}
    public string CompanyName {get; set;}

    public string Position {get; set;}
    public JobStatus Status {get; set;}
}


class Program
{
    static void Main()
    {
        List<Job> jobs = new List<Job>();
        int nextId = 1;

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n=== Job Tracker ===");
            Console.WriteLine("1. Add Job");
            Console.WriteLine("2. List Jobs");
            Console.WriteLine("3. Update Status");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddJob(jobs, ref nextId);
                    break;
                case "2":
                    ListJobs(jobs);
                    break;
                case "3":
                    UpdateStatus(jobs);
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break
            }
        }
    }

    
}