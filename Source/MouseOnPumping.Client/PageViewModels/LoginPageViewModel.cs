using Microsoft.AspNetCore.Components;
using MouseOnPumping.Core;

namespace MouseOnPumping.Client.PageViewModels
{
    public class LoginPageViewModel : ComponentBase
    {
        [Inject]
        public required MouseClient Client { get; init; }

        [Inject]
        public required NavigationManager Navigation { get; init; }

        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public async Task AuthorizeAsync()
        {
            try
            {
                await Client.AuthorizeAsync(Email, Password);
            }
            finally
            {
                if (Client.IsAuthorized)
                    Navigation.NavigateTo("courses");
                    
            }

        }
    }
}
