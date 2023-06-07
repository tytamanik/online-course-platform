using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE.Domain.Entities.Course;

namespace PE.Domain.Entities.Instructor
{
    public class instructorDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Usename is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password confirmation is required.")]
        public string Email { get; set; }
        public List<courseDbTable> Courses { get; set; }
    }
}
