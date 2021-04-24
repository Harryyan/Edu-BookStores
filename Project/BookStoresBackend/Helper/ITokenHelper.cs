using BookStoresBackend.Models;
using System.Security.Claims;

namespace BookStoresBackend.Authorization
{
    public interface ITokenHelper
    {
        ComplexToken CreateToken(User user);
    }
}
