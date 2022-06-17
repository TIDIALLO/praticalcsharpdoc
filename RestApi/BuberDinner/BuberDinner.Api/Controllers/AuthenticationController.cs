using Microsoft.AspNetCore.Mvc;
using BuberDinner.Application.services.Authentication;
using BuberDinner.Domain.Entities;
namespace BuberDinner.Contracts.Authentication;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService){
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request){
        var authResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            reques.Email,
            request.Password
        );

        var response = new AuthenticationResult(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.User.Token
        );
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request){
        var authResult = _authenticationService.Login(
            request.Email,
            request.Password
        );

        var response = new AuthenticationResult(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.User.Token
        );
        return Ok(response);
    }
}