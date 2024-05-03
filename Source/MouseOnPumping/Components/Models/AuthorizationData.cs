using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MouseOnPumping.Core.Models
{
    [JsonSerializable(typeof(AuthorizationData))]
    public class AuthorizationData
    {
        [JsonPropertyName("token")]
        public required string Token { get; init; }
    }
}
