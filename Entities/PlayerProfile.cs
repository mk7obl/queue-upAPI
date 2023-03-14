
using System.ComponentModel.DataAnnotations;

namespace queueUp.Entities
{

    public class PlayerProfile
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(16)]
        public string NickName { get; set; }

        [Required]
        public int GameId { get; set; }

    }
}