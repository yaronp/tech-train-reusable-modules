using Microsoft.Extensions.Options;
using static System.Collections.Specialized.BitVector32;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.Sources.Clear();

IHostEnvironment env = builder.Environment;

builder.Configuration
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
// Add services to the container.

 TechTrain.ReusableModules.Validators.ValidationsOptions.Instance.Load(builder.Configuration.GetSection("Validators"));
 var section = builder.Configuration.GetSection("Validators");

var opt = TechTrain.ReusableModules.Validators.ValidationsOptions.Instance;

builder.Configuration.GetSection("Validators")
    .Bind(opt);


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
