using ErrorOr;
using MediatR;
using Planify.Application.Tasks.Common;
using Planify.Domain.Task.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Tasks.Queries.Get
{
  public record GetTaskQuery(TaskId id) : IRequest<ErrorOr<TaskResult>>;
}
