namespace queueUp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; } = 1;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? CreationDate { get; set; }

    }

}