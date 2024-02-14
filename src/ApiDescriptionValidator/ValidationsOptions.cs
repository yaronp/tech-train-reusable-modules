using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators.Interfaces;

namespace TechTrain.ReusableModules.Validators
{

    public sealed class ValidationsOptions
    {
        private static readonly Lazy<ValidationsOptions> options = new Lazy<ValidationsOptions>(() => new ValidationsOptions());
        public static ValidationsOptions Instance => options.Value;
        public List<IValidator> Validators { get; set; } = new List<IValidator>();
        public Boolean StopOnFirstFailure { get; set; }

        public void Load(IConfigurationSection configurationSection)
        {
            this.StopOnFirstFailure = configurationSection.GetValue<Boolean>("StopOnFirstFailure");
            var validators = configurationSection.GetSection("Validators");
            if (validators != null)
            {
                for ( var i = 0; i < validators.GetChildren().Count(); i++)
                {
                    var validator = validators.GetSection(i.ToString()).Value;
                    if (validator != null)
                    {
                        var t = Type.GetType(validator);
                        if (t != null)
                        {
                            var instance = Activator.CreateInstance(t);
                            if (instance is IValidator)
                            {
                                this.Validators.Add((IValidator)instance);
                            }
                        }
                    }                                          
                }
            }
            configurationSection.Bind(this);
        }
    }
}
