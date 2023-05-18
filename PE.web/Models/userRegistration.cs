using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PE.web.Models
{
    public class userRegistration
    {
        [Key]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        public string LastName{ get; set; }
        [Required(ErrorMessage ="Last Name is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Usename is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Email { get; set; }
    }
}