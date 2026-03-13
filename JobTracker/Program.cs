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
                    break;
            }
        }
    }


    static void AddJob(List<Job> jobs, ref int nextId)
    {
        Console.Write("Company name: ");
        string company = Console.ReadLine();

        Console.Write("Position :");
        string position = Console.ReadLine();

        Job newJob = new Job
        {
            Id = nextId++,
            CompanyName = company,
            Position = position,
            Status =JobStatus.Applied
        };

    jobs.Add(newJob);
    Console.WriteLine("Job Successfully added.");

    }

    static void ListJobs(List<Job> jobs)
    {
        if (jobs.Count == 0)
        {
            Console.WriteLine("No Jobs found.");
            return;
        }

        foreach (var job in jobs)
        {
            Console.WriteLine
            (
                $"ID: {job.Id} | {job.CompanyName} - {job.Position} | Status: {job.Status}"
            );
        }
    }


    static void UpdateStatus(List<Job> jobs)
    {
        Console.WriteLine("Enter Job Id: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid Id.");
            return;
        }

        Job job = jobs.Find(j => j.Id == id);

        if (job == null)
        {
            Console.WriteLine("Job not found.");
            return;
        }

        Console.WriteLine("Select new status:");
        Console.WriteLine("0 - Applied");
        Console.WriteLine("1 - Interview");
        Console.WriteLine("2 - Rejected");
        Console.WriteLine("3 - Offer");

        if (!int.TryParse(Console.ReadLine(), out int statusValue) || !Enum.IsDefined(typeof(JobStatus), statusValue))
        {
            Console.WriteLine("Invalid Status");
            return;
        }

        job.Status = (JobStatus)statusValue;

        Console.WriteLine("Status updated.");
    }

}