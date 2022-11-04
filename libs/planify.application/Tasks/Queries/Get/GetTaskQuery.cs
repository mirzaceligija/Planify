using ErrorOr;
using MediatR;
using Planify.Application.Tasks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Tasks.Queries.Get
{
  public record GetTaskQuery(int id) : IRequest<ErrorOr<TaskResult>>;
}
