using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Domain.Common.Errors
{
  public static class Errors
  {
    public static class Task
    {
      public static Error DuplicateName => Error.Conflict(code: "Task.DuplicateName", description: "Task with the same name already exist!");
    }
  }
}
