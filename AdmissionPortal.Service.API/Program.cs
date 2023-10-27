using AdmissionPortal.Application;
using AdmissionPortal.Application.Feature.Registration.Validator;
using AdmissionPortal.Infra.Data;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddInfraDataRegistration(configuration);
builder.Services.AddApplicationRegistration();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
            builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidation(conf =>
{
    conf.RegisterValidatorsFromAssembly(typeof(CreateApplicationUserValidator).Assembly);
    conf.AutomaticValidationEnabled = false;
});
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();

app.Run();
