using PE.Domain.Entities.categoryDbTable;
using PE.Domain.Entities.Instructor;
using PE.Domain.Entities.User;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PE.Domain.Entities.Course
{
    public class courseDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public categoryDbTable.categoryDbTable Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Lessons { get; set; } 
        public instructorDbTable Author { get; set; }
        public double Price { get; set; }
    }
}
