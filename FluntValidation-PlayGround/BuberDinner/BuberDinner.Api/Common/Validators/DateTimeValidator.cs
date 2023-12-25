using BuberDinner.Application.Common.Interfaces.Services;
using FluentValidation;

namespace BuberDinner.Api.Common.Validators;

public static class DatetTimeValidator
{
    public static IRuleBuilderOptions<T, DateTime> AfterSunrise<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
    {
        var sunrise = TimeOnly.MinValue.AddHours(6);

        return ruleBuilder.Must((objectRoot, datetime, context) =>
                {
                    TimeOnly providedTime = TimeOnly.FromDateTime(datetime);
                    context.MessageFormatter.AppendArgument("Sunrise", sunrise);
                    context.MessageFormatter.AppendArgument("ProvidedTime", providedTime);
                    return providedTime > sunrise;

                })
                .WithMessage("{PropertyName} Start Datetime must be after {Sunrise}. You Provided {ProvidedTime}");

    }
}