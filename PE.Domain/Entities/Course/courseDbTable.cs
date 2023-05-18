using PE.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Domain.Entities.Course
{
    public class courseDbTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Lessons { get; set;}
        public List<userDbTable> Users { get; set; }
        public double price { get; set; }
    }
}
