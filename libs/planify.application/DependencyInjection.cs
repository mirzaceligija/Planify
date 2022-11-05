using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Planify.Application.Common.Behaviors;
using System.Reflection;

namespace Planify.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
      services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
      services.AddMediatR(typeof(DependencyInjection).Assembly);
      services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

      return services;
    }
  }
}
