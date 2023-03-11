
using queueUp.Entities;
using queueUp.Models;

namespace queueUp.Services
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
    }
    public class AccountService : IAccountService
    {
        private readonly PlayerProfileDbContext _context;

        public AccountService(PlayerProfileDbContext context)
        {
            _context = context;
        }

        public void RegisterUser(RegisterUserDto dto)
        {

            var newUser = new User()
            {
                UserName= dto.UserName,
                Email = dto.Email,
                RoleId = dto.RoleId
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
    }
}