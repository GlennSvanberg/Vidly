using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MinNumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock >= 1 || movie.NumberInStock <= 20)
                return ValidationResult.Success;

            if (movie.NumberInStock == null)
                return new ValidationResult("Number in stock is required");

            if (movie.NumberInStock == 0)
                return new ValidationResult("Number in stock can not be zero");


            return new ValidationResult("Number in stock must be between 1 and 20");
        }
    }
}