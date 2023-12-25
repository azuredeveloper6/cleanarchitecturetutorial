using System.ComponentModel.DataAnnotations;
using BuberDinner.Contracts.DataAnnotations;

namespace BuberDinner.Contracts.Authentication;

public record RegisterRequest(
    [MinLength(3),MaxLength(10)]
    string FirstName,
    string LastName,
    string Email,
    string Password,
    
    [Future] DateTime StartDateTime,

    [Future] DateTime EndDateTime,
    List<string> Roles
);