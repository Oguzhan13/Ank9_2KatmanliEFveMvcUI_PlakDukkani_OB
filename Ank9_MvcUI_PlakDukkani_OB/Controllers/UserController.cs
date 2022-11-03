using Microsoft.AspNetCore.Mvc;
using Ank9_MvcUI_PlakDukkani_OB.ViewModels;
using Ank9_EF_Entities_OB.Data;
using Ank9_EF_Entities_OB.Model;

namespace Ank9_MvcUI_PlakDukkani_OB.Controllers
{
    public class UserController : Controller
    {
        private readonly RecordStoreDbContext _db;

        public UserController(RecordStoreDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Yeni Kullanıcı Ekleme
        [HttpGet]
        public IActionResult CreateNewUser()
        {
            return View(new NewUser());
        }
        [HttpPost]
        public IActionResult CreateNewUser(NewUser user)
        {
            if(ModelState.IsValid)
            {
                _db.Users.Add(user.GetUser());
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(user);
            }
        }
        #endregion


    }
}
