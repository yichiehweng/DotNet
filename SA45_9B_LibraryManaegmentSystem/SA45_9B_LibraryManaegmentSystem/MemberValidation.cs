using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class Member: IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            //var property = new[] {"MemberName", "PhoneNumber", "EmailAddress" };
            if (MemberName == "")
            {
                results.Add(new ValidationResult("Please enter a member name", new string[] { "MemberName" }));
            }
            List<string> numbers = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (numbers.Any(MemberName.Contains))
            {
                results.Add(new ValidationResult("Member name cannot contain numbers", new string[] { "MemberName" }));
            }
            if (MemberCategory == "")
            {
                results.Add(new ValidationResult("Member category need to select", new string[] { "MemberCategory" }));
            }
            if (PostalCode.Length != 6)
            {
                results.Add(new ValidationResult("Please enter a correct postal code", new string[] { "PostalCode" }));
            }
            if (PhoneNumber.Length != 7)
            {
                results.Add(new ValidationResult("Please enter a valid phone number", new string[] { "PhoneNumber" }));               
            }
            if (EmailAddress.Contains("@") == false)
            {
                results.Add(new ValidationResult("Please enter a valid email address", new string[] { "EmailAddress" }));
            }
            return results;
        }
    }
    
}
