using System;
using System.ComponentModel.DataAnnotations;

namespace BookMySpoon.Data
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-z0-9-.]+$", ErrorMessage = "Incorrect email format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
