using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoresBackend.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BookStoresBackend.Authorization
{
    public class TokenHelper : ITokenHelper
    {
        private IOptions<JWTConfig> _options;
        public TokenHelper(IOptions<JWTConfig> options)
        {
            _options = options;
        }

        public Token CreateToken(User user)
        {
            Claim[] claims =
                {new Claim(ClaimTypes.NameIdentifier, user.EmailAddress), new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName) };

            return CreateToken(claims);
        }

        private Token CreateToken(Claim[] claims)
        {
            var now = DateTime.Now; var expires = now.Add(TimeSpan.FromMinutes(_options.Value.AccessTokenExpiresMinutes));
            var token = new JwtSecurityToken(
                issuer: _options.Value.Issuer,
                audience: _options.Value.Audience,
                claims: claims,
                notBefore: now,
                expires: expires,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Value.IssuerSigningKey)), SecurityAlgorithms.HmacSha256));
            return new Token { TokenContent = new JwtSecurityTokenHandler().WriteToken(token), Expires = expires };
        }

        public Token RefreshToken(ClaimsPrincipal claimsPrincipal)
        {
            throw new NotImplementedException();
        }


        ComplexToken ITokenHelper.CreateToken(User user)
        {
            throw new NotImplementedException();
        }

        ComplexToken ITokenHelper.CreateToken(Claim[] claims)
        {
            throw new NotImplementedException();
        }
    }
}
