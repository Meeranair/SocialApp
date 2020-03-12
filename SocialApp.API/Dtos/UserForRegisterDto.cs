using System.ComponentModel.DataAnnotations;

namespace SocialApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Not a valid password")]
        public string Password { get; set; }
    }
}