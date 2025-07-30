using EcocysAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")));

// ✅ Allow requests from your Razor page (127.0.0.1:5500)
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        policy => policy
            .WithOrigins("http://127.0.0.1:5500", "http://localhost:5500") 
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// Use middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ✅ Enable CORS
app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();
