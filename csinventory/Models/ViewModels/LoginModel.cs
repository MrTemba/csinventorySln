﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
