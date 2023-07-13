using Microsoft.EntityFrameworkCore; 
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); 


builder.Services.AddControllers(); 
builder.Services.AddDbContext<TodoContext>(opt => 
    opt.UseInMemoryDatabase("TodoList"));
// Adds the database context to the DI container.
// Specifies that the database context will use an in-memory database.

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage(); 
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
