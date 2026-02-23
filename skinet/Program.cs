using Microsoft.EntityFrameworkCore;
using skinet.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StoreContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
