using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using TechTrain.ReusableModules.WebApi.Controllers;
using TechTrain.ReusableModules.Validators;

namespace TechTrain.ReusableModules.Tests;

[TestClass]
public class ApiValidationTests
{
    [TestMethod]
    public void ValidateApi()
    {
        var description = new ApiDescription {
            RelativePath = "/users/{userId}/סל"
        };

        var result = new Validators.ApiDescriptionValidator()
        {
            apiDescription = description
        }.Validate();
        Assert.AreEqual(false, result);
    }
}

public class ValidateUrlLowerCase
{
    [TestMethod]
    public void Validate()
    {
        var description = new ApiDescription
        {
            RelativePath = "/users/{userId}/סל"
        };

        var result = new UrlLowerCaseValidator()        {
            url = description.RelativePath
        }.Validate();
        Assert.AreEqual(false, result);
    }
}