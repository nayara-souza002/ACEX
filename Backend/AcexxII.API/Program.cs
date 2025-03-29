using AcexxII.API.Context;
using AcexxII.API.Repositories;
using AcexxII.API.Services;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using System;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Builder de conexão com o banco 
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Builder services Paciente 
builder.Services.AddScoped<IPacienteInterface, PacienteServices>();

builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<UserValidator>());


// builder do Cors para chamada da API pela porta do front
builder.Services.AddCors(options =>
{
    options.AddPolicy("apiCorsPolicy", build =>
    {
        build.WithOrigins("http://localhost:5500", "127.0.0.1:5500") // Liste as origens permitidas aqui
               .AllowCredentials()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Usando a configuração do cors 
app.UseCors("apiCorsPolicy");

app.MapControllers();

app.Run();
