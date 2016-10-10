using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1005___October_Web_Assignment.Models;

namespace _1005___October_Web_Assignment.Controllers
{
    public class HomeController : Controller
    {
        List<Experience> MyExperienceList;

        public HomeController()
        {
            MyExperienceList = new List<Experience>();
            MyExperienceList.Add(new Experience()
            {
                Title = "Guldkretsen 2016 Finalist",
                Description = "Together with Fredrik Svahn and Axel Ingelsson Fredler as co-creators, we created HTML5 game 'Steampunk and Napalm', a barebones top down space shooter.",
                Period = "2015-16"
            });
            MyExperienceList.Add(new Experience()
            {
                Title = "RPG Maker:er",
                Description = "Making RPG Maker games on a subregular basis with more creativity than raw code which makes the software more addicting and rewarding. My work can be seen on my other Github repo.",
                Period = "2013-"
            });
            MyExperienceList.Add(new Experience()
            {
                Title = "Artist",
                Description = "I enjoy drawing comics and cartoonish characters on my DeviantArt page under the name of QuakerII and has become a hobby since I feel more comfortable with it than programming.",
                Period = "2010-"
            });
            MyExperienceList.Add(new Experience()
            {
                Title = "Gitarist",
                Description = "I can play guitar pretty good. A lesser hobby but preferable over programming.",
                Period = "2011-"
            });
            MyExperienceList.Add(new Experience()
            {
                Title = "Controller-ist",
                Description = "If playing guitar wasn't useless enough, I have developed the talent of playing Guitar Hero flawlessly with an xbox 360 controller.",
                Period = "2011-"
            });
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}