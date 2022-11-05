using Microsoft.Extensions.DependencyInjection;
using Planify.Application.Common.Interfaces.Persistance;
using Planify.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Infrastructure
{
    public static class DependencyInjection
    {
      public static IServiceCollection AddInfrastructure(this IServiceCollection services)
      {
      services.AddScoped<ITasksRepository, TasksRepository>();
      return services;
      }
    }
}
