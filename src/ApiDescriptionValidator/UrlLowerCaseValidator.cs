using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Validators;
using Validators.Interfaces;

namespace TechTrain.ReusableModules.Validators
{
    public class UrlLowerCaseValidator : IValidator
    {
        public ValidatorResult Validate(ApiDescription apiDescription)
        {
            if (string.IsNullOrWhiteSpace(apiDescription.RelativePath))
                return new ValidatorResult(false, "empty path");
            if (apiDescription.RelativePath != apiDescription.RelativePath.ToLower())
                return new ValidatorResult(false, "url is not lowercase");
            return new ValidatorResult(true, string.Empty);
        }
    }


}
