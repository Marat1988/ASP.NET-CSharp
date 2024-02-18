using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    public class Restaurant
    {
        [Display(Name = "Id ресторана")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название ресторана")]
        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Владелец ресторана")]
        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        public string Owner { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }


    }
}