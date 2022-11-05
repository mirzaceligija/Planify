using ErrorOr;
using MediatR;
using Planify.Application.Common.Interfaces.Persistance;
using Planify.Application.Tasks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Tasks.Commands.Create
{
  public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, ErrorOr<TaskResult>>
  {
    private readonly ITasksRepository _tasksRepository;

    public CreateTaskCommandHandler(ITasksRepository tasksRepository)
    {
      _tasksRepository = tasksRepository;
    }

    public async Task<ErrorOr<TaskResult>> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
    {
      var result = _tasksRepository.Add(command.name, command.description);

      return new TaskResult(result, command.name, command.description);
    }
  }
}
