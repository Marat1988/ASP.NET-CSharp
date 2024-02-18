using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    public class Country
    {
        [Display(Name="Id страны")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название страны")]
        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Столица")]
        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        public string Capital { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public Country()
        {
            Restaurants = new List<Restaurant>();
        }

    }
}