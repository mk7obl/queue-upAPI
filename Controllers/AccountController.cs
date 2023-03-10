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
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
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
            var results = _accountService.GetAll();
            return Ok(results);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById([FromRoute] int id)
        {
            var result = _accountService.GetById(id);
            return Ok(result);
        }
    }
}