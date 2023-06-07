using InternTestTask;
using InternTestTask.Repositories;
using InternTestTask.Repositories.Interfaces;
using InternTestTask.Repository;
using InternTestTask.Repository.Interfaces;
using InternTestTask.Services;
using InternTestTask.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to DI container
builder.Services.AddDbContext<InMemoryContext>();
builder.Services.AddScoped<IPointRepository, PointRepository>();
builder.Services.AddScoped<IPointService, PointService>();

builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();

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

var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetService<InMemoryContext>();
context.Database.EnsureCreated();

PointCreator creator = new PointCreator();
var pointService = scope.ServiceProvider.GetService<IPointService>();

foreach (var point in creator.points)
{
    pointService.Insert(point);
}

app.UseStaticFiles();
app.Run();
