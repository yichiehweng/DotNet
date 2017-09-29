using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SA45_9B_LibraryManaegmentSystem
{  
    public partial class Book : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (ISBNNumber == "")
            {
                results.Add(new ValidationResult("Please Enter ISBN Number!", new string[] { "ISBNNumber" }));
                
            }
            if (BookTitle == "")
            {
                results.Add(new ValidationResult("Please Enter Book Title!", new string[] { "BookTitle" }));
                
            }
            if (Genre == "")
            {
                results.Add(new ValidationResult("Please Select Book Genre!", new string[] { "Genre" }));
            }
            if (PublicationDate > DateTime.Now)
            {
                results.Add(new ValidationResult("Publication Date cannot be in the feature!", new string[] { "PublicationDate" }));
            }
            if (stockNumber < 0)
            {
                results.Add(new ValidationResult("Stock Number cannot less than 0!", new string[] { "stockNumber" }));
            }
            return results;
        }
    }
}
