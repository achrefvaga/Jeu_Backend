using Microsoft.EntityFrameworkCore;
using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUser, UserRepo>();
builder.Services.AddScoped<IRoom, RoomRepo>();
builder.Services.AddScoped<IQuestion, QuestionRepo>();
builder.Services.AddScoped<IResponse, ResponseRepo>();
builder.Services.AddScoped<IParticipation, ParticipationRepo>();
builder.Services.AddScoped<ISelection, SelectionRepo>();
builder.Services.AddControllers().AddNewtonsoftJson();  





builder.Services.AddDbContext<DBContextTest>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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
