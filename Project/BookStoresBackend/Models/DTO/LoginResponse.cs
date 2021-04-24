using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresBackend.Models.DTO
{
    public class LoginResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Token AccessToken { get; set; }

        public LoginResponse(User user, Token token)
        {
            Id = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            EmailAddress = user.EmailAddress;
            AccessToken = token;
        }
    }
}
