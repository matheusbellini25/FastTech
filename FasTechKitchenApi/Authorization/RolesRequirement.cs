using FastTechKitchen.Domain.Enums;
using Microsoft.AspNetCore.Authorization;

namespace FastTechKitchen.Api.Authorization;

public class RolesRequirement(PermissionLevel permission) : IAuthorizationRequirement
{
    public PermissionLevel Permission { get; } = permission;
}