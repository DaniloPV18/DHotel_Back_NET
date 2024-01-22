using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.IServices;
using DHotel_Back.Interfaces.Repository;
using DHotel_Back.Interfaces.Services;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name=DefaultConnection"));

builder.Services.AddAutoMapper(typeof(Program));

//builder.Services.AddControllers().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
//});

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DHotel_Back", Version = "v1" });

    // Configuración para JWT en Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Por favor, inserta el token con 'Bearer ' al principio",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        Array.Empty<string>()
    }
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ValidateIssuerSigningKey = true
        };
    });

builder.Services.Configure<FormOptions>(x =>
{
    x.ValueLengthLimit = int.MaxValue;
    x.MultipartBodyLengthLimit = 52428800; // Por ejemplo, 50 MB
});

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = 52428800; // Por ejemplo, 50 MB
});

builder.Logging.AddConsole();

// Servicios Entidades
builder.Services.AddScoped<AbonoReservaService>();
builder.Services.AddScoped<PagoService>();
builder.Services.AddScoped<ServicioOfrecidoService>();
builder.Services.AddScoped<HuespedService>();
builder.Services.AddScoped<AdministradorService>();
builder.Services.AddScoped<HabitacionService>();
//Añadir Servicios - Interfaces
builder.Services.AddScoped<IAbonoReservaRepository, AbonoReservaRepository>();
builder.Services.AddScoped<IPagoRepository, PagoRepository>();
builder.Services.AddScoped<IHabitacionServicioOfrecidoRepository, HabitacionServicioOfrecidoRepository>();
builder.Services.AddScoped<IHabitacionRepository, HabitacionRepository>();
builder.Services.AddScoped<IServicioOfrecidoRepository, ServicioOfrecidoRepository>();
builder.Services.AddScoped<IAdministradorRepository, AdministradorRepository>();
builder.Services.AddScoped<IHuespedRepository, HuespedRepository>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IFileStorageService, FileStorageService>();
//AuthLogin
builder.Services.AddScoped<AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseRouting();

app.UseStaticFiles();

// Middleware para servir archivos desde ImagesGlobal
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(app.Environment.ContentRootPath, "ImagesGlobal")),
    RequestPath = "/ImagesGlobal"
});

app.UseCors("MyCorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
