using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;
using Why.AbstractServices;
using Why.Data.Models;
using Why.Models;
using Why.ModelsServices;
using Why.Repositories;


namespace Why.Controllers
{
    public class HomeController : Controller
    {
        


        ThumbManager tm = new ThumbManager(new ThumbRepository());
        BiographyManager bm = new BiographyManager(new BiographyRepository());
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;
            var values = tm.GetList();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Detail(int id)
        {
            var userClaim = User.Identity.Name;
            ViewBag.userCount = userClaim;


            var bio = bm.GetbyId(id);
            if (bio != null)
            {
                var model = new Biography()
                {
                    BiographyId = bio.BiographyId,
                    BiographyContent = bio.BiographyContent,
                    BiographyTitle = bio.BiographyTitle,
                    BiographyUserName = bio.BiographyUserName,


                };
                return View(model);
            }
            else
            {
                var model = new Biography()
                {
                    BiographyContent = "NUll"
                };

                return View(model);
            }
            
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}