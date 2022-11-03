using Ank9_EF_Entities_OB.Model;
using System.ComponentModel.DataAnnotations;

namespace Ank9_MvcUI_PlakDukkani_OB.ViewModels
{
    public class NewUser
    {
        [Display(Name = "Kullanıcı Adı:")]
        [Required(ErrorMessage = "Kullanıcı alanı boş bırakılamaz")]
        public string UserName { get; set; }
        [Display(Name = "Şifre:")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [StringLength(8, ErrorMessage = "Şifre 8 karakterden oluşmalıdır!")]
        [DataType(DataType.Password)]
        [Compare("RepeatPassword", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string Password { get; set; }
        [Display(Name = "Şifreyi Tekrar Giriniz:")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [StringLength(8, ErrorMessage = "Şifre 8 karakterden oluşmalıdır!")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }

        public User GetUser()
        {
            User user = new User()
            {
                Name = this.UserName,
                Password = this.Password,
            };
            return user;
        }
    }
}
