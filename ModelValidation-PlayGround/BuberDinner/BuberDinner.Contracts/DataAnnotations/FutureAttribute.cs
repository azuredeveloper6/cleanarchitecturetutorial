using System.ComponentModel.DataAnnotations;

namespace BuberDinner.Contracts.DataAnnotations;
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class FutureAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return value is DateTime dateTime && dateTime > DateTime.UtcNow
        ? ValidationResult.Success
        : new ValidationResult("Date must be in Future");
    }

    // public override bool IsValid(object? value)
    // {
    //     return value is DateTime dateTime && dateTime > DateTime.UtcNow;
    // }


}