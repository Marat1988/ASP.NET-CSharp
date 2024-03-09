using System.ComponentModel.DataAnnotations;

namespace TestIocDi.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        [StringLength(25)]
        public string Style { get; set; }
        [Range(1, int.MaxValue)]
        public int Year { get; set; }
        [StringLength(1000)]
        public string OtherInfo { get; set; }
    }
}