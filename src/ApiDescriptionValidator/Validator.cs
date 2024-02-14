using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators;

namespace TechTrain.ReusableModules.Validators
{

    public class Validator
    {
        public List<ValidatorResult> Validate(ApiDescription apiDescription)
        {
            var result = new List<ValidatorResult>();
            // iterate ValidationsOptions.Instance.Validators on each validator call Validate method and collect results to result, return result

            foreach(var v in ValidationsOptions.Instance.Validators)
            {
                result.Add(v.Validate(apiDescription));
            }
            return result; 
        }
    }
}
