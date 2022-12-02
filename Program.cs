using ProyectoWebApi;

var builder = WebApplication.CreateBuilder(args);

// Instancia clase Startup
var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
