using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresBackend.Models
{
    public class JWTTokenConfig
    {
        public string[] Audiences { get; set; }
        public string TokenIssuer { get; set; }
        public string TokenSigningKeyBase64 { get; set; }
        public string AuthenticationScheme { get; set; }
    }
}
