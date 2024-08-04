using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Saleswebmvc.Data;

using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SaleswebmvcContext>(options =>
options.UseMySql(
    "server=127.0.0.1;initial catalog=SalesWeb_Aplication;uid=root;pwd=123456",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.38-mysql")));

builder.Services.AddScoped<SeedingService>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var seedingService = services.GetRequiredService<SeedingService>();
    seedingService.Seed();
}

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
