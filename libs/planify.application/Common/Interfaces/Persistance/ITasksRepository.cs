using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planify.Domain.Task.ValueObjects;

namespace Planify.Application.Common.Interfaces.Persistance
{
  public interface ITasksRepository
  {
    IEnumerable<Domain.Task.Task> GetList();
    Domain.Task.Task? Get(TaskId id);
    TaskId Add(string name, string description);
    Domain.Task.Task? Update(TaskId id, string name, string description);
    void Delete(TaskId id);
  }
}
