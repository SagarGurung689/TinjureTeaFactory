using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TinjureTeaFactory.Infrastructure
{
    public class FileExtensionAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //    var context = (TinjureContext)ValidationContext.GetService(typeof(TinjureContext));


            var file = value as IFormFile;

            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);

                string[] extensions = { "jpg", "png" };

                bool result = extension.Any(x => extension.EndsWith(x));

                if (!result)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
            
        }

        private string GetErrorMessage()
        {
            
            return "Allowed extension are jpg and png.";
           
        }

    }
}
