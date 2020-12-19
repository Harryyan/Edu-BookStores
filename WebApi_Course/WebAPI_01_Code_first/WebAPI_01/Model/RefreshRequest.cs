using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_01.Model
{
    public class RefreshRequest
    {
        public int RefreshRequestId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
