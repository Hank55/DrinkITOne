﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkItOne.Models.ViewModels
{
    public class GuestIndexLogInVM
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter username")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter password")]
        public string Password { get; set; }

        public bool IsLoggedIn { get; set; }
    }
}
