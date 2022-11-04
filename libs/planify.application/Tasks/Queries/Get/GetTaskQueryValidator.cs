using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Tasks.Queries.Get
{
  public class GetTaskQueryValidator : AbstractValidator<GetTaskQuery>
  {
    public GetTaskQueryValidator()
    {
      RuleFor(x => x.id).NotEmpty();
    }
  }
}
