using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;
using FitnessTracker.Data;
using FitnessTracker.Repositories.Interfaces;
using FitnessTracker.Sevices.Interfaces;
using FitnessTracker.Repositories;
using FitnessTracker.Sevices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//string connectionString =
//    builder.Configuration.GetConnectionString("ApplicationContextConnectionString") ??
//    throw new InvalidDataException("Connection string ApplicationContextConnectionString is not found");
string connectionString =
    builder.Configuration.GetConnectionString("ApplicationContextConnectionString") ?? 
    throw new InvalidDataException("No connection");

builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDbContext>(context => context.UseMySQL(connectionString));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
