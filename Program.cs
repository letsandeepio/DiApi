using DiApi.Data;
using DiApi.DataServices;
using DiApi.Middleware;
using DiApi.Utility;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDataRepo, NoSqlDataRepo>();
builder.Services.AddScoped<IDataService, HttpDataService>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();

var app = builder.Build();

app.UseCustomMiddleware();

app.UseHttpsRedirection();

app.MapGet("/data", (IOperationTransient transient, IOperationScoped scoped, IOperationSingleton singleton) =>
{

    Console.WriteLine("Data Endpoint Invoked\n");
    Console.WriteLine($"Transient: {transient.OperationId}\n");
    Console.WriteLine($"Singleton: {singleton.OperationId}\n");
    Console.WriteLine($"Scoped: {scoped.OperationId}\n");
    return Results.Ok();
});

app.Run();
