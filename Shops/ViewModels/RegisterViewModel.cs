using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Shops.Data.Models;
using Shops.Utilities;

namespace Shops.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        [ValidEmailDomain(allowedDomain: "mail.ru",
            ErrorMessage = "Your email domain must be mail.ru")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]

        public string ConfirmPassword { get; set; }


    }
}
