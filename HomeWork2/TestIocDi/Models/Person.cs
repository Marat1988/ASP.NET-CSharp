using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestIocDi.Models
{
    public class Person
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        [StringLength(1000)]
        public string OtherInformation { get; set; }
    }
}