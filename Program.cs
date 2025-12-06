using System.Text.Json.Serialization;
using CliniqueBackend.Data;
using CliniqueBackend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions
      .ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var allowedUrl = builder.Configuration.GetValue<string>("ClientUrl");
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "allowOrigins", policy =>
    {
        policy.WithOrigins(allowedUrl)
          .AllowAnyHeader()
          .AllowAnyMethod();
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DbUrl");
builder.Services.AddDbContext<AppDbContext>(options => options
  .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddScoped<FileUploader>();
builder.Services.AddScoped<IBlogPost, BlogPostService>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("allowOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
