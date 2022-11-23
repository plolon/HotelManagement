using HotelManagement.Api.Extensions;
using HotelManagement.Api.Middlewares;
using HotelManagement.Application;
using HotelManagement.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration    //TODO: Before deploy move credentials to IOptions and add logging to file
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5341/"));

builder.Services.RegisterInfrastructureServices(builder.Configuration);
builder.Services.RegisterApplicationServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterSwagger();
builder.Services.AddAuthorization();
builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

app.UseAuthentication();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelManagement.Api v1"));
}

app.UseSerilogRequestLogging();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();