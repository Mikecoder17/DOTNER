using API.Data;
using API.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // /api/users
public class UsersController : ControllerBase
{
   private readonly DataContext _context;
   public UsersController(DataContext context)
   {
      _context = context; //OR THIS.CONTEXT 
   }

   [HttpGet]
   public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
   {
      var users = await _context.Users.ToListAsync();
      return users;
   }
   [HttpGet("{id}")] // /api/users/1
   public async Task<ActionResult<AppUser>> GetUser(int id)
   {
      return await _context.Users.FindAsync(id);
   }

}
