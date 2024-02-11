using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using TechTrain.ReusableModules.WebApi.Controllers;
using TechTrain.ReusableModules.ApiDescriptionValidator;

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

        var result = new ApiDescriptionValidator.ApiDescriptionValidator().Validate(description);
        Assert.AreEqual("urls should only contain ascii characters", result);
    }
}