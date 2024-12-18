using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public CustomAuthenticationStateProvider(AuthenticationStateProvider authenticationStateProvider)
    {
        _authenticationStateProvider = authenticationStateProvider;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        // Get the authentication state from the default provider
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();

        // Check if the user is authenticated
        var user = authState.User;

        // If the user is not authenticated, return the default state
        if (user.Identity == null || !user.Identity.IsAuthenticated)
        {
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        // Otherwise, return the authenticated user
        return authState;
    }

    public void MarkUserAsAuthenticated(string username)
    {
        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }, "cookie");
        var user = new ClaimsPrincipal(identity);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }

    public void MarkUserAsLoggedOut()
    {
        var identity = new ClaimsIdentity();
        var user = new ClaimsPrincipal(identity);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }
}