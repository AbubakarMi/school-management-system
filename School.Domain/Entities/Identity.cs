using Microsoft.AspNetCore.Identity;
using System;

namespace School.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string Role { get; set; } // Optional display role
    }
}
