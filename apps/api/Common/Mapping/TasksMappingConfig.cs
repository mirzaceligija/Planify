using Mapster;
using Planify.Application.Tasks.Commands.Create;
using Planify.Application.Tasks.Common;
using Planify.Application.Tasks.Queries.Get;
using Planify.Contracts.Tasks;

namespace API.Common.Mapping
{
  public class TasksMappingConfig : IRegister
  {
    public void Register(TypeAdapterConfig config)
    {
      config.NewConfig<CreateTaskRequest, CreateTaskCommand>();
      config.NewConfig<GetTaskRequest, GetTaskQuery>();
      config.NewConfig<TaskResult, TaskResponse>();
    }
  }
}
