using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators;
using Validators.Interfaces;

namespace TechTrain.ReusableModules.Validators
{
    public class ConsistentidValidator : IValidator
    {
        public ValidatorResult Validate(ApiDescription apiDescription)
        {
            if (string.IsNullOrWhiteSpace(apiDescription.RelativePath))
                return new ValidatorResult(false, "error in consistent validator");
            return new ValidatorResult(true, string.Empty); ;
        }
    }
}
