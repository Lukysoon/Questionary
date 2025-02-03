using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RecordManagemant.Validation.CustomAttributes;

public class RequiredIfAttribute : ValidationAttribute
{
    private readonly string _dependentProperty;
    private readonly object _targetValue;

    public RequiredIfAttribute(string dependentProperty, object targetValue)
    {
        _dependentProperty = dependentProperty;
        _targetValue = targetValue;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_dependentProperty);
        if (property != null)
        {
            var dependentValue = property.GetValue(validationContext.ObjectInstance, null);
            if (dependentValue != null && dependentValue.Equals(_targetValue))
            {
                if (value == null)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
        }
        return ValidationResult.Success;
    }
}