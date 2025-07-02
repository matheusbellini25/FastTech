using Microsoft.AspNetCore.Authorization;
using FastTech.Domain.Enums;

namespace FastTech.Api.Authorization;

public static class AuthorizationOptionsExtensions
{
    public static AuthorizationOptions AddPolicyWithPermission(this AuthorizationOptions options, string policyName, PermissionLevel permission)
    {
        options.AddPolicy(policyName, policy => policy.Requirements.Add(new RolesRequirement(permission)));
        return options;
    }
}