using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SA45_9B_LibraryManaegmentSystem
{    
    public partial class Employee:IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (EmployeePhoneNumber.Length != 7)
            {
                results.Add(new ValidationResult("Please enter a valid phone number", new string[] { "PhoneNumber" }));
            }
            if (BirthDate > DateTime.Now)
            {
                results.Add(new ValidationResult("Birthday cannot be in the feature", new string[] { "BirthDate" }));
            }
            return results;
        }
   }

}
