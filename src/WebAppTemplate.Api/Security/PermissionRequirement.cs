using Microsoft.AspNetCore.Authorization;

namespace Dalion.WebAppTemplate.Api.Security {
    public class PermissionRequirement : IAuthorizationRequirement {
        public string[] DelegatedPermissions { get; set; }
        public string[] ApplicationPermissions { get; set; }
    }
}