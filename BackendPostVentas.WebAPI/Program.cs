using BackendPostVentas.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPresentation()
                .AddDependencyApplicacion(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
