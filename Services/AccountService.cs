
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using queueUp.Entities;
using queueUp.Models;

namespace queueUp.Services
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
    public class AccountService : IAccountService
    {
        private readonly PlayerProfileDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AccountService(PlayerProfileDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public void RegisterUser(RegisterUserDto dto)
        {

            var newUser = new User()
            {
                UserName= dto.UserName,
                Email = dto.Email,
                DateOfBirth= dto.DateOfBirth,
                CreationDate = DateTime.Now,
                RoleId = dto.RoleId
            };
            
            var hashedPassword = _passwordHasher.HashPassword(newUser, dto.Password);
            newUser.PasswordHash= hashedPassword;

            _context.Users.Add(newUser);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
           var results = _context
                .Users
                .ToList();

            return results;
        }

        public User GetById(int id)
        {
            var result = _context
                .Users
                .FirstOrDefault(u=>u.Id ==id);

            return result;
        }
    }
}