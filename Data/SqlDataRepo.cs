namespace DiApi.Data
{
  public class SqlDataRepo : IDataRepo
  {
    public string ReturnData()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Returning data from SqlDataRepo");
      Console.ResetColor();
      return "SQL Data from SqlDataRepo";
    }
  }
}