using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PE.Domain.Entities.Course;
using PE.Domain.Enums;
using static PE.Domain.Enums.Roles;

namespace PE.Domain.Entities.User
{
    public class userDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public URoles Role { get; set; } = URoles.user;
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Usename is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password confirmation is required.")]
        public string Email { get; set; }
        public bool isBanned;
        public List<courseDbTable> PurchasedCourses { get; set; }
        public List<courseDbTable> AddedCourses { get; set; }

    }
}
