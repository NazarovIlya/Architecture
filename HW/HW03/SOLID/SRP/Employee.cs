namespace SRP
{
  public class Employee
  {
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Employee(string name, string date)
    {
      Name = name;
      Date = new DateTime(Int64.Parse(date), DateTimeKind.Utc);
    }

    public override string? ToString()
    {
      return string.Format($"Name {0}, date {1}.", Name, Date);
    }
  }
}