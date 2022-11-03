using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_OB.Model
{
    ////Index nameof ile belirttiğimiz property içerisinde IsUnique ile aynı isimden tekrar girilememesini sağlıyoruz
    //[Index(nameof(Name), IsUnique = true)]
    public class User
    {
        //[Key]
        public int UserId { get; set; }
        //[StringLength(30,MinimumLength =3, ErrorMessage ="Karakter sayısı 3 ile 30 aralığında olmalıdır")]
                   
        public string Name { get; set; }
        //[StringLength(8,MinimumLength = 4,ErrorMessage ="Karakter sayısı 4 ile 8 aralığında olmalıdır")]
        public string Password { get; set; }
    }
}
