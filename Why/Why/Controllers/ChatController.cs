using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Why.Data.Models;
using Why.ModelsServices;
using Why.Repositories;

namespace Why.Controllers
{
    public class ChatController : Controller
    {
        ThumbManager tm = new ThumbManager(new ThumbRepository());
        BiographyManager bm = new BiographyManager(new BiographyRepository());
        UserManager um = new UserManager(new UserRepository());
        Thumb thumbsId = new Thumb();


        public IActionResult Chat(string userName, string userEmail)
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;
            var userMail = um.GetList();

            foreach (var item in userMail)
            {
                if (item.UserEmail == User.Identity.Name)
                {
                    ViewBag.UserIdentity = item.UserName;

                }
            }
            
            
            



            return View();
        }
    }
}
