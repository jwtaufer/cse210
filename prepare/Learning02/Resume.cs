public class Resume
{
    public string _person;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_person}");
        Console.WriteLine($"Jobs: ");

        foreach (Job x in _jobs)
        {
            x.DisplayJobDetails();
        }
    }
}