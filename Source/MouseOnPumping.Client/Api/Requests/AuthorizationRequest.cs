using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MouseOnPumping.Core.Requests
{
    [JsonSerializable(typeof(AuthorizationRequest))]
    public class AuthorizationRequest(string email, string password)
    {
        [JsonPropertyName("mail")]
        public string Email { get; set; } = email;
        [JsonPropertyName("password")]
        public string Password { get; set; } = password;
    }
}
