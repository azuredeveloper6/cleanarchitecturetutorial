using BuberDinner.Api.Common.Errors;
using BuberDinner.Api.Common.Mapping;
using BuberDinner.Api.Common.Validators;
using BuberDinner.Contracts.Authentication;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BuberDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, BuberDinnerProblemDetailsFactory>();
        services.AddMappings();
        services.AddScoped<IValidator<RegisterRequest>, RegisterRequestValidator>();
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();

        return services;
    }
}