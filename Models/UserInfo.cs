using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="ad alanı zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "telefon alanı zorunlu")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "mail alanı zorunlu")]
        [EmailAddress(ErrorMessage = "hatalı email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "katılım alanı zorunlu")]
        public bool? WillAttend { get; set; }

    }
}
