using ErfanTermicCourse.Infrastructure.DbContexts;
using ErfanTermicCourse.Infrastructure.Entities;
using ErfanTermicCourse.Infrastructure.Repositories;
using ErfanTermicCourse.Services.TermicCoursesServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ErfanDbContext>(x => x.UseSqlServer(builder.Configuration.
	GetConnectionString("connection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ITermicCourseService, TermicCoursesService>();

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
