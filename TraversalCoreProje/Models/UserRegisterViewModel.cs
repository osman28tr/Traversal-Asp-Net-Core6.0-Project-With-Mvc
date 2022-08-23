using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adinizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadinizi giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanici adinizi giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
