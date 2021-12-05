using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCoffee.Models
{
    [Table("Bills")]
    public class Bills
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string CoffeeID { get; set; }
        public string CoffeeName { get; set; }
        public string TinhChat { get; set; }
        public string SoLuong { get; set; }
        public string DonVi { get; set; }
        public string TheTich { get; set; }
        public string NguonGoc { get; set; }
        [AllowHtml]
        public string DanhGia { get; set; }
    }
}