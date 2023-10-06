using System.Globalization;

namespace SRP
{
  public class Employee
  {
    public string Name { get; set; }
    public DateOnly Date { get; set; }

    public Employee(string name, string date)
    {
      Name = name;
      int[] dateInts = dateParse(date);
      Date = new DateOnly(
        dateInts[2],
        dateInts[1],
        dateInts[0]
        );
    }

    public override string? ToString()
    {
      return string.Format("Name: {0}, date: {1}", Name, Date);
    }

    private int[] dateParse(string date)
    {
      int[] dateInts = new int[3];
      string[] dateArray = date
        .Trim()
        .Replace("\"", string.Empty)
        .Split("/");
      if (dateArray.Length != 3) { throw new ArgumentOutOfRangeException($"Count of args: {dateArray.Length}. Date have to be xx/xx/xx. Just three args."); }
      for (int i = 0; i < dateInts.Length; i++)
      {
        dateInts[i] = int.Parse(dateArray[i]);
      }
      return dateInts;
    }
  }
}