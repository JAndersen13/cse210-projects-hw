public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach (Job jobs in _jobs) 
        {
            jobs.Display();
        }
    }
}