using API.Common.Mapping;
using API.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
      services.AddControllers();
      services.AddEndpointsApiExplorer();
      services.AddMappings();
      services.AddSwaggerGen();
      services.AddSingleton<ProblemDetailsFactory, PlanifyProblemDetailsFactory>();

      return services;
    }
  }
}
