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
  public record CreateTaskCommand(string name) : IRequest<ErrorOr<TaskResult>>;
}
