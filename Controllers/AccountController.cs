using Microsoft.AspNetCore.Mvc;
using queueUp.Entities;
using queueUp.Models;

namespace queueUp.Controllers
{

    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {

       [HttpPost("create")]
       public ActionResult<User> Create([FromBody]RegisterUserDto dto)
       {

            User user = new User();
            user.UserName = dto.UserName;
            user.Email = dto.Email;
            user.PasswordHash = dto.Password;

            return Ok();
       }

        [HttpGet]
        public IEnumerable<User> Get()
        {

        }
    }
}