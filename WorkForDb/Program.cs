using WorkForDb.Database.Context;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Host.ConfigureServices((opt, service) =>
//{
//    service.AddDbContextFactory<DatabaseContext>(options =>
//    {
//        options.UseSqlServer(opt.Configuration.GetSection("mssqlDbString").Value);
//    });
//});
using var context = new DatabaseContext();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
bool createDb = builder.Configuration.GetValue<bool>("createDb");
context.Database.CloseConnection();

if (createDb)
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}
else
{
    context.Database.Migrate();
}

app.UseAuthorization();

app.MapControllers();


app.Run();
