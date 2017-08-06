using System.ComponentModel.DataAnnotations;

namespace okr.Models.ViewModel
{
    public class UserViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}