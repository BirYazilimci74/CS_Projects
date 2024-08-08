﻿using System.Net.Mime;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using API.MyLocalServerAPI.Contexts;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        var connectionStringTodolist = "Server=localhost;Database=todolist;User=root;Password=;"; 
        var connectionStringRideShareApp = "Server=localhost;Database=rideshareapp;User=root;Password=;";
        
        services.AddDbContext<ToDoDbContext>(options =>
            options.UseMySql(connectionStringTodolist, ServerVersion.AutoDetect(connectionStringTodolist)));

        services.AddDbContext<RideShareDbContext>(options =>
            options.UseMySql(connectionStringRideShareApp, ServerVersion.AutoDetect(connectionStringRideShareApp)));

        services.AddControllers();


        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Version = "v1",
                Title = "My API",
                Description = "ASP.NET Core Web API"
            });
        });

        
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }


        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            c.RoutePrefix = string.Empty; // Swagger UI kök URL'de yer alsın
        });


        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
