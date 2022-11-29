using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder();

builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//THE ROUTING ZONE
app.UseRouting();

app.Use(next => context =>
{
    var endpoint = context.GetEndpoint();

    if (endpoint is null)
    {
        return next(context);
    }

    return next(context);
});

app.UseAuthorization();

app.MapGet("/map/hello/{name}", async context =>
{
    var name = context.Request.RouteValues["name"];
    await context.Response.WriteAsync($"Hello {name}!");
});

app.MapRazorPages();

app.Run();
