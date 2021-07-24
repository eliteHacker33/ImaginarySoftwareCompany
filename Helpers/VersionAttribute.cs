using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImaginarySoftwareCompany.Helpers
{
    public class VersionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            try
            {
                if(value == null)
                {
                    return new ValidationResult("Version number is required.");
                }
                Version version = null;
                var stringVersion = value.ToString();
                stringVersion = SoftwareManager.GetStringVersion(stringVersion);
                if(Version.TryParse(stringVersion, out version))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Unable to convert input into a valid Version number, please enter version in the following format: [major version].[minor version].[patch]");
                }
            }
            catch(Exception ex)
            {
                return new ValidationResult("There was an exception thrown trying to get a version number from the provided input. Version input should be in the format: [major version].[minor version].[patch]");
            }
        }
    }
}
