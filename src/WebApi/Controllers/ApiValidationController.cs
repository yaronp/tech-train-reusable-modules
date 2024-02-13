using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using TechTrain.ReusableModules.Validators;

namespace TechTrain.ReusableModules.WebApi.Controllers
{
    [ApiController]
    public class ApiValidationController : ControllerBase
    {
        private readonly IApiDescriptionGroupCollectionProvider _apiDescriptionGroupCollectionProvider;

        public ApiValidationController(IApiDescriptionGroupCollectionProvider apiDescriptionGroupCollectionProvider)
        {
            _apiDescriptionGroupCollectionProvider = apiDescriptionGroupCollectionProvider;
        }

        [HttpGet]
        [Route("/validateApi")]
        public IEnumerable<string> ValidateApi(int userId)
        {
            var validator = new ApiDescriptionValidator();
            var lowerCasevalidator = new UrlLowerCaseValidator();
            foreach(var group in _apiDescriptionGroupCollectionProvider.ApiDescriptionGroups.Items)
            {
                foreach(var item in group.Items)
                {
                    var result = validator.Validate(item) && lowerCasevalidator.Validate(item);

                     if(!result)
                        yield return "Error";       
                }
            }
            // add 2 new validators
        }   
    }
}
