using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTrain.ReusableModules.Validators
{
    public class ConsistentidValidator : IValidator
    {
        public Boolean Validate(ApiDescription apiDescription)

        {
            if (string.IsNullOrWhiteSpace(apiDescription.RelativePath))
                return false;
            return true;
        }
    }
}
