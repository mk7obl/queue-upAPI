namespace queueUp.Models
{

    public class RegisterUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; } = 1;
    }
}