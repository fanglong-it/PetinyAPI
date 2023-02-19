using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using PetinyAPI.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(option => 
    option.AddDefaultPolicy(
            builder =>
            {
                builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
            }
        ));




//DI
builder.Services.AddDbContext<PetinyDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(opt =>
opt.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
);



var app = builder.Build();

//Configure the HTTP request pipeline.

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
