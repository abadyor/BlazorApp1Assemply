using System.ComponentModel.DataAnnotations;

namespace BlazorApp1Assemply.Models
{
    public class Vendor
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string GivenNames { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string Nickname { get; set; }



        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string DocId { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string DocType { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صالح.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string Mobile { get; set; }



        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "هذا الحقل مطلوب.")]
        public string Password { get; set; } = string.Empty;


    }
}
