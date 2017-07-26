using System.ComponentModel.DataAnnotations.Schema;

namespace okr.Models.Database
{
    public class User
    {
        [Column("Id")]
        public string Id {get; set;}
        [Column("FirstName")]
        public string FirstName {get; set;}
        [Column("LastName")]
        public string LastName {get; set;}
        [Column("Password")]
        public string Password {get; set;}
        [Column("Email")]
        public string Email {get; set;}
    }
}