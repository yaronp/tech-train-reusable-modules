using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Routing.Patterns;

namespace TechTrain.ReusableModules.Validators;


public class ApiDescriptionValidator : IValidator
{
    public ApiDescription? apiDescription { get; set; }
    public Boolean Validate()
    {
        if (apiDescription == null)
            return false;

        if (string.IsNullOrWhiteSpace(this.apiDescription.RelativePath))
            return false;

        var Pattern = RoutePatternFactory.Parse(this.apiDescription.RelativePath);
        
        if (!apiDescription.RelativePath.All(char.IsAscii))
            return false;

        return true;
    }

    // url is lower case
    // 

    // consistent identifier name - all ids withing routes should share the same naming pattern 
    // {typeName}Id, or {typeName}Name
}