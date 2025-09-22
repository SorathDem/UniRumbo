using Microsoft.EntityFrameworkCore;
using UniRumbo; // Tu namespace

var builder = WebApplication.CreateBuilder(args);

// Conectar a SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
