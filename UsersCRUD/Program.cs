using Microsoft.EntityFrameworkCore;
using UsersCRUD.Application.AutoMapper;
using UsersCRUD.Data.Context;
using UsersCRUD.IoC;
using AutoMapper;
using UsersCRUD.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UsersCRUDContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("UsersCRUDDB")).EnableSensitiveDataLogging());

NativeInjector.RegisterServices(builder.Services);

builder.Services.AddAutoMapper(typeof(AutoMapperSetup));
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwaggerConfiguration();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
