using BusinessLayer.Service;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;


var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
try
{
	var builder = WebApplication.CreateBuilder(args);
	var connectionString = builder.Configuration.GetConnectionString("SqlConnection");

    // Configure NLog
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();


    // Add services to the container.
    builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));
	builder.Services.AddControllers();
	builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
	builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();

	//Add Swagger
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();


	var app = builder.Build();

	// Configure the HTTP request pipeline.
	app.UseSwagger();
	app.UseSwaggerUI();
	app.UseHttpsRedirection();

	app.UseAuthorization();

	app.MapControllers();

	app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application failed to start.");
    throw;
}
finally
{
    LogManager.Shutdown();
}