namespace BuberDinner.Contracts.Authentication;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password,

    DateTime StartDateTime,

    DateTime EndDateTime,
    List<string> Roles
);