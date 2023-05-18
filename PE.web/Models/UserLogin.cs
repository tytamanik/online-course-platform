﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PE.web.Models
{
    public class userLogin
    {
        [Key]
        public string Username { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password  is required.")]
        public string Email { get; set; }
    }
}