using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTrain.ReusableModules.Validators
{
    public interface IValidator
    {
       public Boolean Validate(ApiDescription apiDescription);
    }

}
