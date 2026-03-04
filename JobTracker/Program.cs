// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

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
        
    }
}