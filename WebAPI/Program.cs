using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.DependencyResolvers.Autofac;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));
var startup = new Startup(builder.Configuration); // My custom startup class.

startup.ConfigureServices(builder.Services); // Add services to the container.

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

startup.Configure(app, app.Environment); // Configure the HTTP request pipeline.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("App is working");
app.Run();
