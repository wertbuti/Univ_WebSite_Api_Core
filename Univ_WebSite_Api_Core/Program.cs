using Microsoft.EntityFrameworkCore;
using Univ_WebSite_Api_Core.Appcode;
using Univ_WebSite_Api_Core.Services;
using Univ_WebSite_Api_Core.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IPersonService,PersonService>();

builder.Services.AddDbContext<UnivEntities>(options=> options.UseSqlServer(
    builder.Configuration.GetConnectionString("MyCon"))
    );


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
