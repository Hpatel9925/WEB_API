using DBContexts.DbContexts;
using DBContexts.Repository;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using ServicesLayer;
using System.Diagnostics;
using WebApiWithDatabase.DatabaseConnection;
using WebApiWithDatabase.Enum;

DatabaseType databaseType = DatabaseType.SqlServerDatabase;

ConnectionString con = new ConnectionString(@"WIN-CB2A0OK4E56\SQLEXPRESS", "EmployeeDatabase", "harshad.patel", "harshad@123");
//ConnectionString con = new ConnectionString("localhost", "myDatabase", "postgres", "harshad@123");

var conString = con.getConnectionString();

var builder = WebApplication.CreateBuilder(args);

// Database connection
    if (databaseType == DatabaseType.SqlServerDatabase)
    {
        builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(conString));
    }
    else 
    {
        builder.Services.AddDbContext<EmployeeContext>(options => options.UseNpgsql(conString));  
    }

// Register Repository and Services 
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
