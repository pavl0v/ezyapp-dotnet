using Ezyapp.Data;
using Ezyapp.Data.Hotels.Queries;
using Ezyapp.Domain.Hotels.Repository;
using Ezyapp.Domain.Hotels.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ApplicationDbContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IGetAllHotelsQuery, GetAllHotelsQuery>();
builder.Services.AddScoped<ICreateHotelQuery, CreateHotelQuery>();
builder.Services.AddScoped<ICreateHotelRawQuery, CreateHotelRawQuery>();
builder.Services.AddScoped<HotelsService>();
builder.Services.AddScoped<CreateHotelService>();

builder.Services.AddControllers();
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
