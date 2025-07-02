using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = $"{AppRoles.Accountant},{AppRoles.SuperAdmin}")]
[ApiController]
[Route("api/[controller]")]
public class FeeController : ControllerBase
{
    // Fee-related endpoints
}
