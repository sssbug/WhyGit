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
    public class AdminController : Controller
    {
        ThumbManager tm = new ThumbManager(new ThumbRepository());
        BiographyManager bm = new BiographyManager(new BiographyRepository());
        UserManager um = new UserManager(new UserRepository());
        Thumb thumbsId = new Thumb();
        




        [Authorize]
        public IActionResult Index()
        {
            List<Thumb> thumbid = new List<Thumb>();
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;

            var thumbList = tm.GetList();

            foreach (var item in thumbList)
            {
                if (item.UsersName == User.Identity.Name)
                {

                    thumbid.Add(item);
                }
                

            }



            if (thumbid == null)
            {
                return View();
            }
            else
            {
                return View(thumbid);
            }

        }
        public IActionResult Create()
        {
            return RedirectToAction("Thumb", "Admin");
        }
        [HttpGet]
        public IActionResult Thumb()
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Thumb(Thumb t)
        {


            t.UsersName = User.Identity.Name;
            
            tm.ThumbAdd(t);
            
            await Task.CompletedTask;
            return RedirectToAction("Biography", "Admin");
        }
        [HttpGet]
        public IActionResult Thumbdel(int id)
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;
            var delThumb = tm.GetbyId(id);
            var delBio = bm.GetbyId(id);
            tm.ThumbRemove(delThumb);
            bm.BiographyRemove(delBio);
            return RedirectToAction("Index","Admin");
        }
        public IActionResult Biography()
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Biography(Biography b)
        {
            if (b.BiographyContent == null)
            {
                List<Thumb> thumbsList = new List<Thumb>();
                b.BiographyContent = "Null";
                var thumbList = tm.GetList();

                foreach (var item in thumbList)
                {
                    if (item.UsersName == User.Identity.Name)
                    {
                        thumbsList.Add(item);

                        
                    }
                }
                b.ThumbsId = thumbsList.Last().ThumbId;
                bm.BiographyAdd(b);
            }
            else
            {
                List<Thumb> thumbsList = new List<Thumb>();
                var thumbList = tm.GetList();

                foreach (var item in thumbList)
                {
                    if (item.UsersName == User.Identity.Name)
                    {
                        thumbsList.Add(item);
                    }
                }
                b.ThumbsId = thumbsList.Last().ThumbId;
                bm.BiographyAdd(b);
            }

            await Task.CompletedTask;
            return RedirectToAction("Index", "Admin");
        }




        
        
        [AllowAnonymous]
        public IActionResult Info(int id)
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;
            var userValue = um.GetList();

            var thumbid = tm.GetbyId(id);

            

            foreach (var item in userValue)
            {
                if (item.UserEmail == thumbid.UsersName)
                {
                    ViewBag.userName = item.UserName;
                    ViewBag.userLast = item.UserLastName;
                    ViewBag.userMail = item.UserEmail;
                }
            }
            return View();
        }


        





    }
}
