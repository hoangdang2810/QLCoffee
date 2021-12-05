using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace QLCoffee.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }

        [AllowHtml]
        public string DanhGia { get; set; }
    }
}