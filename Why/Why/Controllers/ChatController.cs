using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Why.Data;
using Why.Data.Models;
using Why.ModelsServices;
using Why.Repositories;
using Why;

namespace Why.Controllers
{
    public class ChatController : Controller
    {
        ThumbManager tm = new ThumbManager(new ThumbRepository());
        BiographyManager bm = new BiographyManager(new BiographyRepository());
        UserManager um = new UserManager(new UserRepository());
        ChatManager cm = new ChatManager(new ChatRepository());
        Thumb thumbsId = new Thumb();

        
        [Authorize]
        public IActionResult Index(string userEmail)
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;
            var userMail = um.GetList();
            Chat c = new Chat();
            
            foreach (var item in userMail)
            {
                if (item.UserEmail == User.Identity.Name)
                {
                    ViewBag.UserIdentity = item.UserName;
                    c.ChatFirstUserName = item.UserEmail.ToString();
                    
                }
            }
            if (userEmail == null)
            {
                c.ChatSecondUserName = "Null";
            }
            else
            {
                c.ChatSecondUserName = userEmail.ToString();
            }


            string chatUsersName = c.ChatFirstUserName + c.ChatSecondUserName;
            c.ChatUsersName = chatUsersName; 


            cm.ChatAdd(c);



            return View();
        }
    }
}
