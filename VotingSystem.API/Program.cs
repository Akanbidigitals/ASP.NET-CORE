using Microsoft.EntityFrameworkCore;
using VotingSystem.API.DataAccess.DataContext;
using VotingSystem.API.DataAccess.Interfaces;
using VotingSystem.API.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
////////////////////////////////////////
//Adding our connection string 
builder.Services.AddDbContext<VotingSystemContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("VotingSystem"));
});
//----------------Dependency Injection-------------------------//

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();

//---------------------------------------------------

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
