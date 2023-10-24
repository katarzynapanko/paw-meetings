using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.Common.Config;
using PetsFile.Application.Matching.Interfaces;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Commands.Handlers;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Pets.Validators;
using PetsFIle.Infrastructure.Common.Database;
using PetsFIle.Infrastructure.Matching.Database;
using PetsFIle.Infrastructure.Owners.Database;
using PetsFIle.Infrastructure.Pets.Database;
using PetsFIle.Infrastructure.PetsMetadata.Checker;
using PetsFIle.Infrastructure.PetsMetadata.Database;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<RegisterOwnerCommandHandler>());
builder.Services.AddAutoMapper(Assembly.Load("PetsFIle.Infrastructure"));
builder.Services.AddValidatorsFromAssemblyContaining<PetRegistrationModelValidator>();
builder.Services.AddDbContext<PawsMeetingsDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("PawsMeetings")));
builder.Services.AddScoped<IPetMatchReader, PetMatchReader>();
builder.Services.AddScoped<ITraitChecker, TraitChecker>();
builder.Services.AddScoped<IPetReader, PetReader>();
builder.Services.AddScoped<IPetWriter, PetWriter>();
builder.Services.AddScoped<IPetTypeReader, PetTypeReader>();
builder.Services.AddScoped<IPetTypeWriter, PetTypeWriter>();  
builder.Services.AddScoped<IPhotoWriter, PhotoWriter>();
builder.Services.AddScoped<ITraitReader, TraitReader>();
builder.Services.AddScoped<ITraitWriter, TraitWriter>();
builder.Services.AddScoped<IOwnerAddressReader, OwnerAddressReader>();
builder.Services.AddScoped<IOwnerAddressWriter, OwnerAddressWriter>();
builder.Services.AddScoped<IOwnerReader, OwnerReader>();
builder.Services.AddScoped<IOwnerWriter, OwnerWriter>();
builder.Services.AddRazorPages();
builder.Services.Configure<MatchingOptions>(builder.Configuration.GetSection(MatchingOptions.Matching));
//builder.Services.Configure<DapperOptions>(builder.Configuration.GetSection(DapperOptions.Configuration));
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
