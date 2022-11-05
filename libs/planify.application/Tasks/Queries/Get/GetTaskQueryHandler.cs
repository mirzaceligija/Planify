using ErrorOr;
using MediatR;
using Planify.Application.Common.Interfaces.Persistance;
using Planify.Application.Tasks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Tasks.Queries.Get
{
  public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, ErrorOr<TaskResult>>
  {
    private readonly ITasksRepository _tasksRepository;

    public GetTaskQueryHandler(ITasksRepository tasksRepository)
    {
      _tasksRepository = tasksRepository;
    }

    public async Task<ErrorOr<TaskResult>> Handle(GetTaskQuery query, CancellationToken cancellationToken)
    {
      var result = _tasksRepository.Get(query.id);
      return new TaskResult(result.Id, "Task name", "a");
    }
  }
}
