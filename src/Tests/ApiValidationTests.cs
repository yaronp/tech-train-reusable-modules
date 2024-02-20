using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using TechTrain.ReusableModules.Validators;
using TechTrain.ReusableModules.WebApi.Controllers;

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

        var result = new Validators.ApiDescriptionValidator().Validate(description);
        Assert.AreEqual(false, result.IsValid);
    }

    [TestMethod]
    public void ValidateConsistency()
    {
        var description = new ApiDescription
        {
            RelativePath = "/users/{userId}/test1"
        };

        var result = new ConsistentidValidator().Validate(description);
        Assert.AreEqual(false, result.IsValid);
    }

    [TestMethod]
    public void ValidateLowerCase()
    {
        var description = new ApiDescription
        {
            RelativePath = "/users/{userId}/סל"
        };

        var result = new UrlLowerCaseValidator().Validate(description);
        Assert.AreEqual(false, result.IsValid);
    }
}
