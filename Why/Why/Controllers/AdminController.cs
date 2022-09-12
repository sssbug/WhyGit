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
                else
                {
                    //ViewBag.thumbid = ;
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
                b.BiographyContent = "Null";
                bm.BiographyAdd(b);
            }
            else
            {
                bm.BiographyAdd(b);
            }



            await Task.CompletedTask;
            return RedirectToAction("Index", "Admin");
        }
    }
}
