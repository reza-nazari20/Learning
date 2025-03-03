using System.ComponentModel.DataAnnotations;

namespace Tag_Helper.Models
{
    public class User
    {
        [Display(Name="نام")]
        [Required]
        public string Name { get; set; }
        [Display(Name="نام خانوادگی")]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public bool Gender { get; set; }
        [Range(15,50)]
        public byte Age { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Url)]
        public string WebSite { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
    }
}
