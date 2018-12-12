using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(200, ErrorMessage = "Password cannot be longer than 200 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public Roles Role { get; set; }
    }

    public enum Roles
    {
        admin,
        monitorservice,
        user,
    }
}
