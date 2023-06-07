using PE.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PE.web.Models
{
    public class courseCreation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Lessons { get; set; }
        public double price { get; set; }
    }
}