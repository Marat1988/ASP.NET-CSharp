using System.ComponentModel.DataAnnotations;

namespace TestIocDi.ViewModel
{
    public class BookViewModel
    {
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

        public BookViewModel(string name, string author, string style, int year, string otherInfo)
        {
            Name = name;
            Author = author;
            Style = style;
            Year = year;
            OtherInfo = otherInfo;
        }
    }
}