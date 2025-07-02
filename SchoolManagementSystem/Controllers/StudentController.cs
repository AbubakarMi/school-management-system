using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = $"{AppRoles.SuperAdmin},{AppRoles.Principal}")]
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    // Student endpoints here
}