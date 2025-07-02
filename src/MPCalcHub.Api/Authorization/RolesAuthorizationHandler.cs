using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using MPCalcHub.Domain.Enums;
using MPCalcHub.Infrastructure.Extensions;

namespace MPCalcHub.Application.Authorization;

public class RolesAuthorizationHandler : AuthorizationHandler<RolesRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RolesRequirement requirement)
    {
        var roleClaim = context.User.FindFirst(c => c.Type == ClaimTypes.Role)?.Value;

        if (roleClaim.IsNullOrEmpty() == false && Enum.TryParse<PermissionLevel>(roleClaim, out var userRoles))
        {
            if (requirement.Permission.HasAnyFlag(userRoles)) 
            {
                context.Succeed(requirement);
            }
        }
        return Task.CompletedTask;
    }
}
