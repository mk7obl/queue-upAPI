using Microsoft.AspNetCore.Mvc;
using queueUp.Entities;
using queueUp.Models;
using queueUp.Services;

namespace queueUp.Controllers
{

    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly PlayerProfileDbContext _dbContext;
        private readonly IAccountService _accountService;

        public AccountController(PlayerProfileDbContext dbContext, IAccountService accountService)
        {
            _dbContext = dbContext;
            _accountService = accountService;
        }
        [HttpPost("register")]
        public ActionResult<User> Create([FromBody] RegisterUserDto dto)
        {
            _accountService.RegisterUser(dto);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById([FromQuery]int id)
        {
            var result = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            return Ok(result);
        }
    }
}