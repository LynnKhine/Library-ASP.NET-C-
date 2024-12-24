using Microsoft.EntityFrameworkCore;
using LibrarySystem.Data;
using LibrarySystem.Controllers;
using LibrarySystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register DbContext with MSSQL connection string (db context)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<AuthorService>();
builder.Services.AddTransient<BookService>();
builder.Services.AddTransient<BorrowHistoryService>();
builder.Services.AddTransient<CategoryService>();
builder.Services.AddTransient<CustomerService>();
builder.Services.AddTransient<RoleService>();
builder.Services.AddTransient<StaffService>();

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
