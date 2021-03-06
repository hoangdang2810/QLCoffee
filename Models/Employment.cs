using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCoffee.Models
{
    [Table("Employment")]
    public class Employment
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string EmploymentID { get; set; }
        public string EmploymentName { get; set; }
        public string Address { get; set; }

    }
}