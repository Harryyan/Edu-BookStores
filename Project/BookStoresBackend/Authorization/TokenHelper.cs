using Microsoft.Extensions.Options;
using System;
using BookStoresBackend.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Cryptography;

namespace BookStoresBackend.Authorization
{
    public class TokenHelper : ITokenHelper
    {
        private readonly IOptions<JWTConfig> _options;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public TokenHelper(IOptions<JWTConfig> options)
        {
            _options = options;
        }

        /// <summary>
        /// Create new access token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public ComplexToken CreateToken(User user)
        {
            Claim[] claims =
                {new Claim(ClaimTypes.NameIdentifier, user.EmailAddress), new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName) };

            return CreateToken(claims);
        }

        private ComplexToken CreateToken(Claim[] claims)
        {
            var now = DateTime.Now;
            var expires = now.Add(TimeSpan.FromMinutes(_options.Value.AccessTokenExpiresMinutes));
            var token = new JwtSecurityToken(
                issuer: _options.Value.Issuer,
                audience: _options.Value.Audience,
                claims: claims,
                notBefore: now,
                expires: expires,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Value.IssuerSigningKey)), SecurityAlgorithms.HmacSha256));

            var accessToken = new Token { TokenContent = new JwtSecurityTokenHandler().WriteToken(token), Expires = expires };
            var refreshToken = RefreshToken();
            var complexToken = new ComplexToken()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };

            return complexToken;
        }

        private Token RefreshToken()
        {
            var refreshToken = new Token();
            var randomNumber = new byte[32];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                refreshToken.TokenContent = Convert.ToBase64String(randomNumber);
            }
            refreshToken.Expires = DateTime.UtcNow.AddMonths(6);

            return refreshToken;
        }
    }
}
