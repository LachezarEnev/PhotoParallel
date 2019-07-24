﻿namespace Photoparallel.Web.ViewModels.Rents
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Common;

    public class RentProductInputModel
    {
        [Required]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "City/Village")]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Postal code")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Postal code must be exactely 4 digits!")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Start Day")]
        [DataType(DataType.Date)]
        public DateTime RentDate { get; set; } = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(1);

        [Required]
        [Display(Name = "End Day")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; } = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(1);

        public decimal TotalPrice { get; set; }

        public decimal ShippingCosts { get; set; }

        public string Comment { get; set; }
    }
}