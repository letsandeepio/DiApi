using DiApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDataRepo, SqlDataRepo>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/data", (IDataRepo repo) =>
{
    // var repo = new SqlDataRepo();
    repo.ReturnData();
    return Results.Ok();
});

app.Run();
