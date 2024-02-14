using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Routing.Patterns;
using Validators;
using Validators.Interfaces;

namespace TechTrain.ReusableModules.Validators;


public class ApiDescriptionValidator : IValidator
{
    
        public ValidatorResult Validate(ApiDescription apiDescription)
    {
        if (apiDescription == null)
            return new ValidatorResult(false, "no apiDescription");

        if (string.IsNullOrWhiteSpace(apiDescription.RelativePath))
            return new ValidatorResult(false, "empty path");        

        var Pattern = RoutePatternFactory.Parse(apiDescription.RelativePath);

        if (!apiDescription.RelativePath.All(char.IsAscii))
            return new ValidatorResult(false,"error");

        return new ValidatorResult(true, string.Empty);
    }


    // url is lower case
    // 

    // consistent identifier name - all ids withing routes should share the same naming pattern 
    // {typeName}Id, or {typeName}Name
}