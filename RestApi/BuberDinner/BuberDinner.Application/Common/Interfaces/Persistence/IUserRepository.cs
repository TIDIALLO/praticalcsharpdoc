using BuberDinner.Domain.Entities;
namespace BurbarDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}