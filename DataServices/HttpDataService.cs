namespace DiApi.DataServices
{
  public class HttpDataService : IDataService
  {
    public string GetProductData(string url)
    {
      Console.WriteLine("----> Getting Product data...");
      return "some product data";
    }
  }
}