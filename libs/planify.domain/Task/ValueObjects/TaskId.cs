using Planify.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Domain.Task.ValueObjects
{
  public sealed class TaskId : ValueObject
  {
    public Guid Value { get; }

    private TaskId(Guid value)
    {
      Value = value;
    }

    public static TaskId CreateUnique()
    {
      return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
