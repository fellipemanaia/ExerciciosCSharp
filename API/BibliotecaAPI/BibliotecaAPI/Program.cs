using BibliotecaAPI.Interfaces;
using BibliotecaAPI.Repositories;
using BibliotecaAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//registra as classes para que o ASP.NET consiga criar elas automaticamente

//Injeção de dependencias
//quando alguem pedir um ILvroRepository
//vai entregar LivroRepository
//new LivroRepository()
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<LivroService>();

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
