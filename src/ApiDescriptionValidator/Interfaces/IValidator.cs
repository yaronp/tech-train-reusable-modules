using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators.Interfaces
{
    public interface IValidator
    {
        public ValidatorResult Validate(ApiDescription apiDescription);
    }

}
