using Microsoft.EntityFrameworkCore;
using SimpleNotesApi.Data; // přidat pro DbContext

var builder = WebApplication.CreateBuilder(args);

// 💾 Přidání SQLite databáze a EF Core
builder.Services.AddDbContext<NotesDbContext>(options =>
    options.UseSqlite("Data Source=notes.db"));

// Zbytek necháme jak je
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
