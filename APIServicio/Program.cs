using ProyectoPrueba.AccesoDatos;
using ProyectoPrueba.Negocio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connStr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSingleton(new SQLHelper(connStr));

builder.Services.AddScoped<IProducto, NProducto>();
builder.Services.AddScoped<IVenta, NVenta>();

builder.Services.AddControllers();

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
