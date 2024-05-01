using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controllers;


public class UserController : CustomizedController
{
   private IUserService  _userService;

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
   public List<User> FindMany()
   {
      return _userService.FindMany();
   }

   [HttpGet("{email}")]
   public User? FindOne(string email)
   {
      return _userService.FindOneByEmail(email);
   }

   [HttpPost]
   [ProducesResponseType(StatusCodes.Status201Created)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public ActionResult<User> CreateOne([FromBody] User user)
   { if (user is not null)
   {
       var createdUser = _userService.CreateOne(user);
       return CreatedAtAction(nameof(CreateOne),createdUser);
   } 
      return BadRequest();
      
   }
}
