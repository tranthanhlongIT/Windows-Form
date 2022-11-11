using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project2.Ultils
{
    public class ObjectValidator : IDataErrorInfo
    {
        [Browsable(false)]
        public string this[string property]
        {
            get
            {
                var propertyDes = TypeDescriptor.GetProperties(this)[property];
                if (propertyDes == null)
                    return string.Empty;
                IList<ValidationResult> validationResults = new List<ValidationResult>();
                var results = Validator.TryValidateProperty(propertyDes.GetValue(this),
                    new ValidationContext(this, null, null) { MemberName = property }, validationResults);
                if (!results)
                    return validationResults.First().ErrorMessage;
                return string.Empty;
            }
        }

        [Browsable(false)]
        public string Error
        {
            get
            {
                var valResults = new List<ValidationResult>();
                bool result = Validator.TryValidateObject(this, new ValidationContext(this, null, null), valResults);
                if (!result)
                    return string.Join(Environment.NewLine, valResults.Select(e => e.ErrorMessage));
                return null;
            }
        }

        [Browsable(false)]
        public bool IsValid => String.IsNullOrEmpty(Error);
    }
}
