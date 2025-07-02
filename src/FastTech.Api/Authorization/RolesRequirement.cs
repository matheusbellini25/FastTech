using Microsoft.AspNetCore.Authorization;
using FastTech.Domain.Enums;

namespace FastTech.Api.Authorization;

public class RolesRequirement(PermissionLevel permission) : IAuthorizationRequirement
{
    public PermissionLevel Permission { get; } = permission;
}