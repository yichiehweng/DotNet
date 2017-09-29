using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class IssueTran : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (MemberID == "")
            {
                results.Add(new ValidationResult("MemberID cannot be empty", new string[] { "MemberID" }));
            }
            if (ISBNNumber == "")
            {
                results.Add(new ValidationResult("ISBNNumber cannot be empty", new string[] { "ISBNNumber" }));
            }
            if (EmployeeID == "")
            {
                results.Add(new ValidationResult("EmployeeID cannot be empty", new string[] { "EmployeeID" }));
            }
            if (DateIssue >DateTime.Today)
            {
                results.Add(new ValidationResult("Issue Cannot be in the feature", new string[] { "DateIssue" }));
            }
            if (DateDue < DateTime.Today)
            {
                results.Add(new ValidationResult("Due Date Cannot be in the pass", new string[] { "DateDue" }));
            }
            return results;

        }
    }
}
