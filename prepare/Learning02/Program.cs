using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Accenture";
        //job1.Display();        

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Ocean";
        //job2.Display();

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Allison Rose";

        resume1.Display();
    }
}