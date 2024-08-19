using DevOpsTest.Models;
using DevOpsTest.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<GameBdContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("Db"));
});

builder.Services.AddControllers();
builder.Services.AddScoped<IDataService, BdDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
