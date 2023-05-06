using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PE.web.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Usename is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password confirmation is required.")]
        public string ConfirmationPassword { get; set; }
        [Required(ErrorMessage ="Email is required.")]
        public string Email { get; set; }

    }
}
