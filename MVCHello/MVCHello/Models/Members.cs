using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCHello.Models
{
    public class Members
    {
        [Key]
        public int MemberID { get; set; }
        [Required(ErrorMessage = "Please enter firstname")]
        //[RegularExpression(@"^[a-zA-Z]$", ErrorMessage ="Enter valid name")]
        public string FirstName { get; set; }
        //[RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Enter valid name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Please enter lastname")]
        //[RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Enter valid name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Enter valid Email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Please confirm the password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}