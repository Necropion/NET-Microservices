using Authentication.Data;
using Authentication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Controller;

[ApiController]
[Route("api/[controller]")]
public class UserController :ControllerBase
{
    private readonly DatabaseContext databaseContext;

    public UserController(DatabaseContext context)
    {
        databaseContext = context;
    }
    
    // GET ALL USERS
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUser()
    {
        return await databaseContext.User.ToListAsync();
    }
    
    // POST USER
    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(User user)
    {
        databaseContext.User.Add(user);
        await databaseContext.SaveChangesAsync();
        
        return user;
    }
}