using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Dalion.WebAppTemplate.Api.Security {
    public class PermissionRequirementHandler : AuthorizationHandler<PermissionRequirement> {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement) {
            if (requirement.DelegatedPermissions.Any(p => context.User.HasClaim(ClaimTypes.Scope, p))) {
                context.Succeed(requirement);
            }
            else if (requirement.ApplicationPermissions.Any(p => context.User.HasClaim(ClaimTypes.Role, p))) {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}