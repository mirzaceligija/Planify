using ErrorOr;
using MediatR;
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
    /*private readonly ITasksRepository _tasksRepository;

    public CreateTaskCommandHandler(ITasksRepository tasksRepository)
    {
      _tasksRepository = tasksRepository;
    }
    */

    public async Task<ErrorOr<TaskResult>> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
    {

      /*
      var task = new Planify.Domain.Task.Task(command.name, "desc")
      {
        Name = command.name
      };


      _tasksRepository.Create(task);
      */

      return new TaskResult(1, command.name);
    }
  }
}
