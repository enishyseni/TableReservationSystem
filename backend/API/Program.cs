using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Application.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

<<<<<<< HEAD
//obsolete
//builder.Services.AddControllers().AddFluentValidation(config => 
//{
//    config.RegisterValidatorsFromAssemblyContaining<Application.ReservationMediatRClasses.Create>();
//});

//new methods instead of AddFluentValidation():
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<Application.ReservationMediatRClasses.Create>();

=======
builder.Services.AddControllers();
>>>>>>> aaf168ae71ebd05796dc972272de64b4a7c13aa6
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMediatR(AppDomain.CurrentDomain.Load("Application"));

builder.Services.AddMediatR(typeof(Application.ReservationMediatRClasses.List.Handler).Assembly);
builder.Services.AddMediatR(typeof(Application.RestaurantMediatRClasses.List.Handler).Assembly);
builder.Services.AddMediatR(typeof(Application.UserMediatRClasses.List.Handler).Assembly);

builder.Services.AddAutoMapper(typeof(RestaurantMappingProfiles).Assembly);
builder.Services.AddAutoMapper(typeof(ReservationMappingProfiles).Assembly);
builder.Services.AddAutoMapper(typeof(UserMappingProfiles).Assembly);


var app = builder.Build();

var scopeFactory = app.Services.GetRequiredService<IServiceProvider>();

using (var scope = scopeFactory.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    context.Database.Migrate();//qetu osht errori 
    //await Seed.SeedData(context);
}

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
