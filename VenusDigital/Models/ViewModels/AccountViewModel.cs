﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Authorization;

namespace VenusDigital.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address!")]
        [MaxLength(250)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must contain minimum eight characters, at least one letter, one number and one special character")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Compare("Password",ErrorMessage = "Password and RePassword does not match")]
        public string RePassword { get; set; }
        [Display(Name = "Username")]
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }
        [Display(Name = "Phone Number")]
        [MaxLength(250)]
        public string PhoneNumber { get; set; }


    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address!")]
        [MaxLength(250)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class WishlistViewModel
    {
        [Required]
        [MaxLength(250)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductImage { get; set; }
        [Required]
        public float ProductScore { get; set; }
        [Required]
        public decimal ProductMainPrice { get; set; }
        public decimal ProductOffPrice { get; set; }
        [Required]
        public int ReviewsCount { get; set; }
        [Required]
        public int QuantityInStock { get; set; }

        public int ProductId { get; set; }

    }

    public class ForgetPasswordViewModel
    {
        public string Email { get; set; }
    }

    public class RecoverPasswordViewModel
    {
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password and ConfirmPassword does not match")]
        public string ConfirmPassword { get; set; }
    }
    public class ShowUserInformation
    {
        public int userId { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string TelephoneNumber { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Display(Name = "Email Address")]
        [Required]
        [MaxLength(250)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address !")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Current Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [Required]
        [Display(Name = "New Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password and confirm password does not match !")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangeInfoViewModel
    {
        [Required]
        [Display(Name = "Phone")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [MaxLength(250)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address !")]
        public string Email { get; set; }
        [Display(Name = "Postal Address")]
        [Required]
        [MaxLength(800)]
        public string Address { get; set; }
        [Display(Name = "Zip Code")]
        [Required]
        [MaxLength(20)]
        public string ZipCode { get; set; }
        [Display(Name = "Telephone")]
        [Required]
        [MaxLength(20)]
        public string TelephoneNumber { get; set; }
    }
}
