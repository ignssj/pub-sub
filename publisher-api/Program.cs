using Microsoft.Extensions.Logging;
using publisher_api.src.Application;
using publisher_api.src.Domain.Interfaces;
using publisher_api.src.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddPublisher("amqp://localhost:5672", "guest", "guest");
builder.Services.AddScoped<IPublisher, MessagePublisher>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
