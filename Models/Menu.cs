using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCoffee.Models
{
        [Table("Menu")]
        public class Menu
        {
            [Key]
            [Column(TypeName = "VARCHAR")]
            [StringLength(50)]
            public string CoffeeID { get; set; }
            public string CoffeeName { get; set; }
            public string SoLuong { get; set; }
            public string TheTich { get; set; }
            public string ThemTopping { get; set; }
            [AllowHtml]
            public string DanhGia { get; set; }
        }
}