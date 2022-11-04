using ErrorOr;
using Planify.Application.Services.Tasks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Services.Tasks.Queries
{
  public class TaskQueryService : ITaskQueryService
  {
    public ErrorOr<TaskResult> Get()
    {
      return new ErrorOr<TaskResult>();
    }
  }
}
