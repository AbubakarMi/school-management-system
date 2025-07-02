using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using School.Domain.Entities.Identity;

namespace School.Infrastructure.Seed
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            string[] roleNames = {
                "SuperAdmin",
                "Principal",
                "Teacher",
                "Student",
                "Parent",
                "Accountant"
            };

            foreach (var role in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole<Guid>(role));
                }
            }
        }
    }
}
