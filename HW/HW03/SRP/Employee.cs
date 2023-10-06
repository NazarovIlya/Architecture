using System.Globalization;

namespace SRP
{
  public class Employee
  {
    public string Name { get; set; }
    public DateOnly Date { get; set; }

    public Employee(string name, int year, int month, int day)
    {
      Name = name;
      Date = new DateOnly(year, month, day);
    }

    public override string? ToString()
    {
      return string.Format("Name: {0}, date: {1}", Name, Date);
    }
  }
}