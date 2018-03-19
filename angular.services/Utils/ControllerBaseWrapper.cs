using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace angular.services.Utils
{
    public abstract class ControllerBaseWrapper : ControllerBase
    {
        [NonAction]
        public virtual CreatedResult Created(object model)
        {
            return (CreatedResult)new ObjectResult(model){StatusCode = 201};
        }
    }
}
