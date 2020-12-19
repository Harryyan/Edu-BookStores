using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_01.Model
{
    public class JWTSettings
    {
        public int JWTSettingsId { get; set; }
        public string SecretKey { get; set; }
    }
}
