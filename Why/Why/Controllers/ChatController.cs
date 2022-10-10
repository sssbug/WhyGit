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
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace Why.Controllers
{
    public class ChatController : Controller
    {
        public string emptyValue;

        public string chatUsers;
        public string chatFistUsers;
        public string chatSecondUsers;
        ThumbManager tm = new ThumbManager(new ThumbRepository());
        BiographyManager bm = new BiographyManager(new BiographyRepository());
        UserManager um = new UserManager(new UserRepository());
        ChatManager cm = new ChatManager(new ChatRepository());
        ChatMessageManager cmm = new ChatMessageManager(new ChatMessageRepository());
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
                    chatFistUsers = c.ChatFirstUserName;
                }
            }
            if (userEmail == null)
            {
                c.ChatSecondUserName = "Null";
            }
            else
            {
                c.ChatSecondUserName = userEmail.ToString();
                chatSecondUsers = c.ChatSecondUserName;
            }


            string chatUsersName = c.ChatFirstUserName + c.ChatSecondUserName;
            c.ChatUsersName = chatUsersName;


            WhyDbContext s = new WhyDbContext();
            var dataValue = s.Chats.FirstOrDefault(x => x.ChatUsersName == c.ChatUsersName);
            if (dataValue != null)
            {

                chatUsers = c.ChatUsersName;


            }
            else
            {
                cm.ChatAdd(c);
            }

            
            return View();
        }
        public IActionResult ChatUserMessage(string user, string otherUser, string users)
        {
            List<string> messageList = new List<string>();
            var usersMessage = cmm.GetList();
            foreach (var item in usersMessage)
            {
                if (users == item.ChatMessageUsersName)
                {
                    messageList.Add(item.ChatMessageContent);
                }
            }
            
            return RedirectToRoute(messageList);
        }


        public IActionResult ChatCounter(string msg)
        {
            ChatMessage c = new ChatMessage();
            c.ChatMessageFirstUserName = chatFistUsers;
            c.ChatMessageSecondUserName = chatSecondUsers;
            c.ChatMessageUsersName = chatUsers;
            c.ChatMessageContent = msg;
            cmm.ChatMessageAdd(c);

            msg = JsonConvert.SerializeObject(msg);
            return Json(msg);
        }

    }
}

