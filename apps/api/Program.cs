using API.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Planify.Application;
using Planify.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddControllers();

  builder.Services.AddEndpointsApiExplorer();
  builder.Services.AddSwaggerGen();

  builder.Services.AddApplication();
  builder.Services.AddInfrastructure();

  builder.Services.AddSingleton<ProblemDetailsFactory, PlanifyProblemDetailsFactory>();
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
