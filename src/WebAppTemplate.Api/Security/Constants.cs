namespace Dalion.WebAppTemplate.Api.Security {
    public static class Constants {
        public static class Scopes {
            public const string ApiFullAccess = "Api.FullAccess";
        }

        public static class ClaimTypes {
            public const string Scope = "http://schemas.microsoft.com/identity/claims/scope";
            public const string Role = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
        }
    }
}