using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Web Designer";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume newResume = new Resume();
        newResume._name = "Heather Hopkins";
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.DisplayResume();
    }
    
}
