using BuberDinner.Application.Common.Interfaces.Authentication;
using BurbarDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public readonly IJwtTokenGenerator _jwtTokenGenerator;

    private readonly IUserRepository _userRepository;
    public AuthenticationService(
        IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
     {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password){
        
        //1. Validate the  user does not exists
        if(_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with given email already exists.");
        }
        //2. Create user(generate uniqueId) & persist to DB
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName, 
            Email = email, 
            Password = password
        };
        _userRepository.Add(user);
        //creat JWT Token        
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthenticationResult(
            user,
            token
        );
    }
    public AuthenticationResult Login(string email, string password){
        //1. Validate the  user does not exists
        if(_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User with given email already exists.");
        }
        //2. Validate the apassword is correct
        if (user.Password != password)
        {
            throw new Exception("Invalid password");
        }

        //3. Create Jwt Token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }
} 