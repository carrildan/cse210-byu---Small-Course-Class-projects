public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 2019;
    public int _endYear = 2022;


     public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}), {_startYear} - {_endYear}");
    }
}


   