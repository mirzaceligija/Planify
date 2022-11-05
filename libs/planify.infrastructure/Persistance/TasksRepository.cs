using Planify.Application.Common.Interfaces.Persistance;
using Planify.Domain.Task.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Infrastructure.Persistance
{
  public class TasksRepository : ITasksRepository
  {
    private static List<Domain.Task.Task> tasks = new List<Domain.Task.Task>();

    public IEnumerable<Domain.Task.Task> GetList()
    {
      return tasks;
    }

    public Domain.Task.Task? Get(TaskId id)
    {
      var result = tasks.FirstOrDefault(x => x.Id == id);
      return result;
    }

    public TaskId Add(string name, string description)
    {
      var task = Domain.Task.Task.Create(name, description);
      tasks.Add(task);

      return task.Id;
    }

    public void Delete(TaskId id)
    {
      var task = tasks.FirstOrDefault(x => x.Id == id);
      tasks.Remove(task);
    }

    public Domain.Task.Task? Update(TaskId id, string name, string description)
    {
      var task = tasks.FirstOrDefault(x => x.Id == id);
      task.Name = name;
      task.Description = description;
      return task;
    }
  }
}
