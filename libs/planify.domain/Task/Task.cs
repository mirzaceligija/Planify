using Planify.Domain.Models;
using Planify.Domain.Task.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Domain.Task
{
  public sealed class Task : AggregateRoot<TaskId>
  {
    public string Name { get; set; }
    public string Description { get; set; } = null!;

    private Task(TaskId id, string name, string description) : base(id)
    {
      Name = name;
      Description = description;
    }

    public static Task Create(string name, string description)
    {
      return new(
        TaskId.CreateUnique(),
        name,
        description);
    }
  }
}
