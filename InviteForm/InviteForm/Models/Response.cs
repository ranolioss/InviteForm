using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InviteForm.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please enter your email ID")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please neter your address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "will you come to our party? ")]
        public bool? AttendOrNot { get; set; }
    }
}