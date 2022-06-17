using BuberDinner.Domain.Entities;
namespace BuberDinner.Contracts.Authentication;

public record AthenticationRequest(
    User User,
    string Token);