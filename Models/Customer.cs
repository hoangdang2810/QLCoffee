using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCoffee.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }

        [AllowHtml]
        public string DanhGia { get; set; }
    }
}