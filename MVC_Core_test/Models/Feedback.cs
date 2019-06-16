using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_test.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Enter your email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", 
            ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Enter your message")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
