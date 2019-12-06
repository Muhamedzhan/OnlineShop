using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shops.Data.Models
{
    public class Order : IValidatableObject
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name="Enter your name")]
        [StringLength(20)]
        [Required(ErrorMessage ="The length of the name should be more than 5")]
        public string name { get; set; }

        [Display(Name = "Enter your surname")]
        [StringLength(20)]
        [Required(ErrorMessage = "The length of the name should be more than 5")]
        public string surname { get; set; }

        [Display(Name = "Enter your address")]
        [StringLength(35)]
        [Required(ErrorMessage = "The length of the name should be more than 5")]
        public string address { get; set; }

        [Display(Name = "Enter your phone")]
        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "The length of the name should be equals to 11")]
        public string phone { get; set; }

        [Display(Name = "Enter your email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "The length of the name should be more than 5")]
        public string email { get; set; }

        [BindNever]
        //[ScaffoldColumn(false)]
        public DateTime dateTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (name.Equals("admin"))
            {
                yield return new ValidationResult(
                    $"You cannot be admin",
                    new[] { "name" });
            } 
        }
    }
}
