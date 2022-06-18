using CPA.ApplicationWeb;

// -------------------------------------------------------

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddControllers();

var cnnString = builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

Dependency.Configure(builder.Services, cnnString);

// -------------------------------------------------------

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.ConfigureExceptionHandler();

app.MapGet("/", () => "Servidor API -> CPA Fácil");

app.Run();
