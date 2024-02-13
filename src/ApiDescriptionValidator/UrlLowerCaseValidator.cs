using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TechTrain.ReusableModules.Validators
{
    public class UrlLowerCaseValidator : IValidator
    {
        public Boolean Validate(ApiDescription apiDescription)
        {
            if (string.IsNullOrWhiteSpace(apiDescription.RelativePath))
                return false;
            return apiDescription.RelativePath == apiDescription.RelativePath.ToLower();
        }
    }


}
