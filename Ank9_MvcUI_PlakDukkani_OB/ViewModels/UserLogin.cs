using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ank9_MvcUI_PlakDukkani_OB.ViewModels
{
    public class UserLogin
    {
        [Display(Name = "Kullanıcı Adı:")]
        [Required(ErrorMessage = "Kullanıcı alanı boş bırakılamaz")]
        public string UserName { get; set; }
        [Display(Name = "Şifre:")]
        [Required(ErrorMessage ="Şifre alanı boş bırakılamaz")]
        [StringLength(8, ErrorMessage ="Şifre 8 karakterden oluşmalıdır!")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}
