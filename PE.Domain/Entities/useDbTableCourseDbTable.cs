using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Domain.Entities
{
    public class userDbTableCourseDbTable
    {
        [Key] public int Id { get; set; }
        public int User { get; set; }
        public int Course { get;set; }
    }
}
