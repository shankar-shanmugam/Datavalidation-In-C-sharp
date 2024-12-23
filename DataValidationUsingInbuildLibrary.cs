using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegularExpressionInC_
{
    internal class DataValidationUsingInbuildLibrary
    {
        public static void validate()
        {

            Product p = new Product
            {
           //     Id = 12,
                Name = "cream",
                ListPrice = 55.43m,
                //     color ="white",
                sellEndDate = Convert.ToDateTime("2024-09-20"),
              //  ProductNumber = "12334444"

            };

            var e = new ValidationContext(p);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(p, e, results, true);

            if (isValid) Console.WriteLine("all are valid");
            else
            {
                foreach (ValidationResult result in results)
                {
                    foreach (var memberName in result.MemberNames)
                    {
                        Console.WriteLine($"Property: {memberName} Error: {result.ErrorMessage}");
                    }
                }

            }

        }



    }
}
