using DiApi.DataServices;

namespace DiApi.Data
{
  public class NoSqlDataRepo : IDataRepo
  {
    private readonly IServiceScopeFactory _scopeFactory;

    // private readonly IDataService _dataService;

    public NoSqlDataRepo(IServiceScopeFactory serviceScopeFactory)
    {
      //_dataService = dataService;
      _scopeFactory = serviceScopeFactory;
    }
    public string GetData()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Returning data from NoSqlDataRepo");


      using (var scope = _scopeFactory.CreateScope())
      {
        var dataService = scope.ServiceProvider.GetRequiredService<IDataService>();
        dataService.GetProductData("https://something.com/api");
        Console.ResetColor();
        return "SQL Data from NoSqlDataRepo";
      }


    }

    public string ReturnData()
    {
      return GetData();
    }
  }
}