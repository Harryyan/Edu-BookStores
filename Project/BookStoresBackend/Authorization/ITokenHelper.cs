using BookStoresBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookStoresBackend.Authorization
{
    public interface ITokenHelper
    {
        ComplexToken CreateToken(User user);
        ComplexToken CreateToken(Claim[] claims);
        Token RefreshToken(ClaimsPrincipal claimsPrincipal);
    }
}
