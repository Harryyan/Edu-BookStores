using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoresBackend.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoresBackend.Models;
using BookStoresBackend.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace BookStoresBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly BookStoreContext _context;
        private readonly JWTConfig _jwtConfig;

        /// <summary>
        /// Init
        /// </summary>
        /// <param name="context"></param>
        /// <param name="config"></param>
        public UsersController(BookStoreContext context, JWTConfig config)
        {
            _context = context;
            _jwtConfig = config;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<User>), Status200OK)]
        public IActionResult GetUsers()
        {
            return Ok(_context.Users.AsQueryable());
        }

        /// <summary>
        /// Get user by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), Status200OK)]
        [ProducesResponseType(Status404NotFound)]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Get user by Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("{email}")]
        [ProducesResponseType(typeof(User), Status200OK)]
        [ProducesResponseType(Status404NotFound)]
        public async Task<IActionResult> GetUser(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress == email);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        #region Login & Register
        /// <summary>
        /// Sign Up a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        [ProducesResponseType(Status201Created)]
        [ProducesResponseType(Status400BadRequest)]
        [ProducesResponseType(Status409Conflict)]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _context.Users.AnyAsync(u => u.EmailAddress == user.EmailAddress);

            if (result)
            {
                return Conflict("The User Already Existed!");
            }

            if (user.EmailAddress == null || user.Password == null || user.Password.Length < 6)
            {
                return BadRequest("Parameters Wrong!");
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { email = user.EmailAddress }, user);
        }

        /// <summary>
        /// Login with email and password
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        [ProducesResponseType(typeof(ComplexToken), Status200OK)]
        [ProducesResponseType(Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress == user.EmailAddress);

            if (result == null)
            {
                return BadRequest("User Not Exists!");
            }

            var complexToken = new TokenHelper(_jwtConfig).CreateToken(result);
            var response = new LoginResponse(result, complexToken.AccessToken);

            return Ok(response);
        }

        #endregion
    }
}
