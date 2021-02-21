using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresBackend.Authorization
{
    public class AdminRoleHandler : AuthorizationHandler<AdminRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AdminRequirement requirement)
        {
            if (context.User.IsInRole("Administrator"))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
