using Application.v1.Mappings;
using DependencyInjection.v1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddProjectDependenciesV1();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


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
