using DiApi.DataServices;

namespace DiApi.Data
{
  public class NoSqlDataRepo : IDataRepo
  {
    private readonly IDataService _dataService;

    public NoSqlDataRepo(IDataService dataService)
    {
      _dataService = dataService;
    }
    public string GetData()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Returning data from NoSqlDataRepo");
      Console.ResetColor();
      _dataService.GetProductData("https://something.com/api");
      return "SQL Data from NoSqlDataRepo";
    }

    public string ReturnData()
    {
      return GetData();
    }
  }
}