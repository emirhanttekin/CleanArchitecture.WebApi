using CleanArchitecture.Application.Features.RoleFeatures.Commands.CreateRole;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Persistance.Services;

public sealed class RoleService : IRoleService
{
    private readonly RoleManager<Role> _roleManger;

    public RoleService(RoleManager<Role> roleManger)
    {
        _roleManger = roleManger;
    }

    public async Task CreateAsync(CreateRoleCommand request)
    {
        Role role = new()
        {
            Name = request.Name,
        };
        await _roleManger.CreateAsync(role);
    }
}
