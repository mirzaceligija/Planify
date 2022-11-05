using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planify.Application.Tasks.Commands.Create;
using Planify.Application.Tasks.Common;
using Planify.Application.Tasks.Queries.Get;
using Planify.Contracts.Tasks;
using Planify.Domain.Task.ValueObjects;

namespace API.Controllers
{
  public class TasksController : BaseController
  {
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public TasksController(ISender mediator, IMapper mapper)
    {
      _mediator = mediator;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetTaskRequest request)
    {
      //TODO: Fix Mapster issue
      var query = _mapper.Map<GetTaskQuery>(request);
      ErrorOr<TaskResult> taskResult = await _mediator.Send(query);

      return taskResult.Match(
        taskResult => Ok(_mapper.Map<TaskResult>(taskResult)),
        errors => Problem(errors));
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTaskRequest request)
    {
      //TODO: Fix Mapster issue
      var command = _mapper.Map<CreateTaskCommand>(request);
      ErrorOr<TaskResult> taskResult = await _mediator.Send(command);

      if (taskResult.IsError && taskResult.FirstError == Planify.Domain.Common.Errors.Errors.Task.DuplicateName)
      {
        return Problem(statusCode: StatusCodes.Status400BadRequest, title: taskResult.FirstError.Description);
      }

      return taskResult.Match(
        taskResult => Ok(_mapper.Map<TaskResult>(taskResult)),
        errors => Problem(errors));
    }

    //NOTE: This chunk of code is temporary
    [HttpGet("TestError")]
    public IActionResult TestError()
    {
      ErrorOr<string> err = GetError();

      if (err.IsError && err.FirstError == Planify.Domain.Common.Errors.Errors.Task.DuplicateName)
      {
        return Problem(statusCode: StatusCodes.Status400BadRequest, title: err.FirstError.Description);
      }

      return err.Match(
        result => Ok("Everything is fine!"),
        errors => Problem(errors)
      );
    }

    //NOTE: This chunk of code is temporary
    private ErrorOr<string> GetError()
    {
      return Planify.Domain.Common.Errors.Errors.Task.DuplicateName;
    }
  }
}
