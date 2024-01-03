using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PetsFile.Application.Authentication;
using PetsFile.Application.Authentication.Interfaces;
using PetsFile.Application.Common.Config;
using PetsFile.Application.Common.Constants;
using PetsFile.Application.Matching.Interfaces;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Commands.Handlers;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Authentication.Interfaces;
using PetsFile.Authentication.Services;
using PetsFile.Pets.Validators;
using PetsFIle.Infrastructure.Common.Database;
using PetsFIle.Infrastructure.Matching.Database;
using PetsFIle.Infrastructure.Owners.Database;
using PetsFIle.Infrastructure.Owners.Http;
using PetsFIle.Infrastructure.Pets.Database;
using PetsFIle.Infrastructure.PetsMetadata.Checker;
using PetsFIle.Infrastructure.PetsMetadata.Database;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PawsMeetingsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PawsMeetings")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<PawsMeetingsDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

#region registrations
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<RegisterOwnerCommandHandler>());
builder.Services.AddAutoMapper(Assembly.Load("PetsFIle.Infrastructure"), Assembly.Load("PetsFile.Application"));
builder.Services.AddValidatorsFromAssemblyContaining<PetRegistrationModelValidator>();
builder.Services.AddScoped<IOwnerApi, OwnerApi>();
builder.Services.AddScoped<IIdentityUserFactory, IdentityUserFactory>();
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
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<ITokenFactory, TokenFactory>();
builder.Services.AddHttpClient(HttpClientNames.PawsMeetingsApi, x => x.BaseAddress = new Uri("https://localhost:7268/"));
#endregion

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
