using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using apiMailID.Services;

namespace apiMailID.Controller;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase{
    
    [HttpPost("register")]
    public IActionResult RegisterUser(string username){
        var emailSender = new EmailSender();
        emailSender.SendEmail(username);
        return Ok();
    }

}