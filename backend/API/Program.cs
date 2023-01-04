using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Application.Core;
using FluentValidation.AspNetCore;
using FluentValidation;
using API.Middleware;
using Application.DTOs;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.AllowAnyMethod()
                                 .AllowAnyHeader()
                                 .AllowCredentials()
                                 .WithOrigins("http://localhost:3000");
                      });
});

//obsolete
builder.Services.AddControllers().AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssemblyContaining<Application.ReservationMediatRClasses.Create>();
});

//new methods instead of AddFluentValidation():
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<Application.ReservationMediatRClasses.Create>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddMediatR(AppDomain.CurrentDomain.Load("Application"));

builder.Services.AddMediatR(typeof(Application.ReservationMediatRClasses.List.Handler).Assembly);
builder.Services.AddMediatR(typeof(Application.RestaurantMediatRClasses.List.Handler).Assembly);
builder.Services.AddMediatR(typeof(Application.UserMediatRClasses.List.Handler).Assembly);

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

var app = builder.Build();

//UserDTO ObjectName = JsonConvert.DeserializeObject < UserDTO > (jsonString);

var scopeFactory = app.Services.GetRequiredService<IServiceProvider>();

using (var scope = scopeFactory.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    context.Database.Migrate(); //possible error
    await Seed.SeedData(context);
}

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();//e kom shtu vet
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();

