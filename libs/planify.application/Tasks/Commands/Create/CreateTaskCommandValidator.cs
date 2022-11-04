using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Tasks.Commands.Create
{
  public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
  {
    public CreateTaskCommandValidator()
    {
      RuleFor(x => x.name).NotEmpty();
    }
  }
}
