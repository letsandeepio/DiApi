using DiApi.Data;
using DiApi.DataServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDataRepo, NoSqlDataRepo>();
builder.Services.AddScoped<IDataService, HttpDataService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/data", (IDataRepo repo) =>
{
    repo.ReturnData();
    return Results.Ok("Hello World!");
});

app.Run();
