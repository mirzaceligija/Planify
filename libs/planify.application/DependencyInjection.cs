using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Planify.Application.Common.Behaviors;
using Planify.Application.Services.Tasks.Commands;
using Planify.Application.Services.Tasks.Queries;
using Planify.Application.Tasks.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
