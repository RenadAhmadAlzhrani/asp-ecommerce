using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.DTOs;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Services;
using CodeCrafters_backend_teamwork.src.Utility;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controllers;


public class UserController : CustomizedController
{
   private IUserService _userService;

   public UserController(IUserService userService)
   {
      _userService = userService;
   }

   [HttpPatch("{email}")]
   public User? UpdateOne(string email, [FromBody] User user)
   {
      return _userService.UpdateOne(email, user);
   }

   [HttpGet]
   [ProducesResponseType(StatusCodes.Status200OK)]
   public IEnumerable<UserReadDto> FindMany()
   {
      return _userService.FindMany();
   }

   [HttpGet("{email}")]
   public ActionResult<UserReadDto?> FindOne(string email)
   {
      return Ok(_userService.FindOneByEmail(email));
   }

   [HttpPost]
   [ProducesResponseType(StatusCodes.Status201Created)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public ActionResult<User> CreateOne([FromBody] User user)
   {
      Console.WriteLine($"{user.Email}");

      if (user is not null)
      {

         var createdUser = _userService.CreateOne(user);
         return CreatedAtAction(nameof(CreateOne), createdUser);
      }
      return BadRequest();

   }
   [HttpPost("/test")]
   [ProducesResponseType(StatusCodes.Status201Created)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public ActionResult<UserReadDto> CreateOneTest([FromBody] UserCreateDto user)
   {
      Console.WriteLine($"{user.Email}");

      if (user is not null)
      {

         var createdUser = _userService.CreateOneTest(user);
         return CreatedAtAction(nameof(CreateOne), createdUser);
      }
      return BadRequest();

   }
}
