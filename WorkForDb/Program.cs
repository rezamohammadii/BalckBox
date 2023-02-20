using WorkForDb.Database.Context;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Host.ConfigureServices((opt, service) =>
//{
var conn = builder.Configuration.GetSection("mssqlDbString").Value;

builder.Services.AddDbContext<MariaDbContext>(options => options
       .UseMySql(conn,ServerVersion.AutoDetect(conn)));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//builder.Services.AddScoped<MariaDbContext>();
using var context = new MariaDbContext();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
bool createDb = builder.Configuration.GetValue<bool>("createDb");
if (createDb)
{
    context.Database.EnsureDeleted();
    context.Database.Migrate();
}
else
{
    context.Database.Migrate();
}

app.UseAuthorization();

app.MapControllers();


app.Run();
