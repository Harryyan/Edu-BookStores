/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStores.Models;
using Microsoft.AspNetCore.Identity;
using BookStoresBackend.Models;

namespace BookStoresBackend.Controllers
{
    [Route("api")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly BookStoresDBContext _context;

        public AccountController(BookStoresDBContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            return Ok();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            var userExists = await userManager.FindByNameAsync(user.FirstName);

            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse { Status = "Error", Message = "User already exists!" });

            User newUser = new User()
            {
                EmailAddress = user.EmailAddress,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserId = Guid.NewGuid()
            };

            var result = await userManager.CreateAsync(newUser, user.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            return Ok(new ErrorResponse { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] User model)
        {
            var userExists = await userManager.FindByNameAsync(model.FirstName);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse { Status = "Error", Message = "User already exists!" });

            User newUser = new User()
            {
                EmailAddress = model.EmailAddress,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserId = Guid.NewGuid()
            };
            var result = await userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));

            if (!await roleManager.RoleExistsAsync("User"))
                await roleManager.CreateAsync(new IdentityRole("User"));

            if (await roleManager.RoleExistsAsync("Admin"))
            {
                await userManager.AddToRoleAsync(newUser, "Admin");
            }

            return Ok(new ErrorResponse { Status = "Success", Message = "Admin User created successfully!" });
        }
    }
}
*/