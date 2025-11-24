public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English.");
    }

    public void SalaryInfo()
    {
        Console.WriteLine("Teacher salary information.");
    }
}
