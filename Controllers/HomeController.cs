using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int saat = DateTime.Now.Hour;

            //ViewBag.Selamlama= saat > 12 ? "iyi günler" : "günaydın";
            //ViewBag örnek
            //ViewBag.UserName = "Oğuzhan İŞCAN";

            ViewData["Selamlama"] = saat > 12 ? "iyi günler" : "Günaydın";
            //ViewData["UserName"] = "Oğuzhan İŞCAN";
            int usercount = Repository.Users.Where(i => i.WillAttend == true).Count();

            var meetinginfo = new MeetingInfo() 
            { 
            Id = 1,
            Location="istabul,kongre merkezi",
            Date = new DateTime(2024,01,20,20,0,0),
            NumberOfPeople = usercount
            };



            return View(meetinginfo);
        }
    }
}
