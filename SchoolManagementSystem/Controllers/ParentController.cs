using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = AppRoles.Parent)]
[ApiController]
[Route("api/[controller]")]
public class ParentController : ControllerBase
{
    // Parent views child grades, pays fees, etc.
}
