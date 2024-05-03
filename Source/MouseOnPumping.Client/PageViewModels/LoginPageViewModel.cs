using Microsoft.AspNetCore.Components;
using MouseOnPumping.Services;

namespace MouseOnPumping.Client.PageViewModels
{
    public class LoginPageViewModel : ComponentBase
    {
        [Inject]
        public required AuthorizationService AuthorizationService { get; init; }

        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public async Task AuthorizeAsync() 
        {
            await AuthorizationService.AuthorizeAsync(Email, Password);
        }
    }
}
