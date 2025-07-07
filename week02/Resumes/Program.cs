using System;

public class Program
{
    public static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;
        job1._endYear = 2025;
        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2021;
        job2._endYear = 2025;
        
        Resume resume1 = new Resume();
        resume1._name = "John Doe";
        resume1.Add(job1);
        resume1.Add(job2);
        
        resume1.DisplayResume();
    }
}