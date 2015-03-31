using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class UserViewModel
    {
        [ScaffoldColumn(true)]
        public int Id { get; set; }

        [Display(Name="User Name"), MaxLength(50), Required]
        public string UserName { get; set; }

        [Timestamp, Display(Name="Birth Date"), Required]
        public DateTime BirthDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Timestamp, Display(Name="Add Date")]
        public DateTime AddDate {get; set;}

        [Timestamp]
        public DateTime Modiefied{get; set;}

        [Display(Name="Is Active")]
        public bool IsActive {get; set;}

        [Display(Name="Books Borrowed")]
        public int BooksBorrowed { get; set; }
    }
}