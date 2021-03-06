using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLCoffee.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "PassWord is required")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}