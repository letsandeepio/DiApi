namespace DiApi.Data
{
  public class NoSqlDataRepo : IDataRepo
  {
    public string GetData()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Returning data from NoSqlDataRepo");
      Console.ResetColor();
      return "SQL Data from NoSqlDataRepo";
    }

    public string ReturnData()
    {
      return GetData();
    }
  }
}