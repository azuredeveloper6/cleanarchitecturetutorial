using System.Data;
using BuberDinner.Application.Common.Interfaces.Services;
using BuberDinner.Contracts.Authentication;
using FluentValidation;

namespace BuberDinner.Api.Common.Validators;


public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator(IDateTimeProvider dateTimeProvider)
    {
        // RuleFor(x => x.StartDateTime).Must(x => x > dateTimeProvider.UtcNow);
        // RuleFor(x => x.EndDateTime).GreaterThan(x => x.StartDateTime);

        // RuleForEach(x => x.Roles).Must(NotBeEmpty)
        //     .WithMessage("Registration must have one role(s)");

        RuleFor(x => x.StartDateTime).AfterSunrise();
    }

    private static bool NotBeEmpty(string roleName)
    {
        return roleName.Length > 0;
    }
}