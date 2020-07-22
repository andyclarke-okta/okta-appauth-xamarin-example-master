namespace OktaDemo.XF.Helpers
{
    public class Constants
    {
        public const string AuthStateKey = "authState";
        public const string AuthServiceDiscoveryKey = "authServiceDiscovery";

        public const string ClientId = "0oaowx94seN1iPJHY0h7";
        public const string RedirectUri = "com.oktapreview.aclarke:/callback";
        public const string PostLogoutRedirectUri = "com.oktapreview.aclarke:/logoutCallback";
        public const string OrgUrl = "https://aclarke.oktapreview.com";
        public const string AuthorizationServerId = "default";

        public static readonly string DiscoveryEndpoint =
            $"{OrgUrl}/oauth2/{AuthorizationServerId}/.well-known/openid-configuration";


        public static readonly string[] Scopes = new string[] {
            "openid", "profile", "email", "offline_access" };
    }
}
