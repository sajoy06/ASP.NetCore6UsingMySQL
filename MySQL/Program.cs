using Microsoft.EntityFrameworkCore;
using MySQL.Models;

var builder = WebApplication.CreateBuilder(args);
//Register services Start

var connectionString = builder.Configuration.GetConnectionString("MySql");

builder.Services.AddDbContextPool<AppDbContext>(
    options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
    );

builder.Services.AddScoped<IEmployeeRepository,MySQLEmployeeRepository>();

builder.Services.AddMvc();

//builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();



//Register services End 

var app = builder.Build();
//Register middleware Start

//app.UseAuthentication();

//Register middleware End

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
