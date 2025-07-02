using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[AllowAnonymous]
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // Login/Register here
}
