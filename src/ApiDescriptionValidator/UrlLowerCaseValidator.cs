using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TechTrain.ReusableModules.Validators
{
    public class UrlLowerCaseValidator : IValidator
    {
        public string? url {  get; set; } 
        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.url))
                return false;
            return this.url == this.url.ToLower();
        }
    }


}
