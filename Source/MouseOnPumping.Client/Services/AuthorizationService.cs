using MouseOnPumping.Core;

namespace MouseOnPumping.Services
{
    public class AuthorizationService(MouseClient client)
    {

        public async Task AuthorizeAsync(string email, string password) 
        {
            await client.AuthorizationRequest(email, password);
        }
    }
}
