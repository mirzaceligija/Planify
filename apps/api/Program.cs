using API;
using Planify.Application;
using Planify.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddPresentation();
}

var app = builder.Build();
{
  if (app.Environment.IsDevelopment())
  {
    app.UseSwagger();
    app.UseSwaggerUI();
  }

  app.UseExceptionHandler("/error");
  app.UseHttpsRedirection();
  app.MapControllers();
  app.Run();
}
