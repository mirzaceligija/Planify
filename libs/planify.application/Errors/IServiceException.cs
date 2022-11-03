using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Application.Errors
{
  public interface IServiceException
  {
    public HttpStatusCode StatusCode { get; set; }
    public string ErrorMessage { get; set; }
  }
}