using System;
using System.ComponentModel.DataAnnotations;

namespace TestIocDi
{
    public class PersonViewModel
    {
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        [StringLength(1000)]
        public string OtherInformation { get; set; }

        public PersonViewModel(string firstName, string lastName, DateTime? birthDay, string otherInformation)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            OtherInformation = otherInformation;
        }
    }
}