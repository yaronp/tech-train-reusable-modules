using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTrain.ReusableModules.Validators;

namespace ApiDescriptionValidators
{

    public class ValidatorConfiguration
    {
        public List<IValidator>? Validators { get; set; }
        public Boolean StopOnFirstFailure { get; set; }
    }

    public interface IValidatorResult
    {
        public Boolean IsValid { get; set; }
        public String Message { get; set; }
    }

    public class Validator
    {
        public ValidatorConfiguration validatorConfiguration { get; set; } = new ValidatorConfiguration();

        public List<IValidatorResult> Validate()
        {
            return new List<IValidatorResult>();
        }
        // api surface to validators

        // configuration with list of validators to run allowing to select which validations to run

        // create response object instead of boolean
    }
}
