using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Contracts.Tasks
{
  public record TaskResponse(int id, string name, string description);
}
