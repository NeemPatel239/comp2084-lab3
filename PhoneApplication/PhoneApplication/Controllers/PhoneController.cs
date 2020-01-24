using PhoneApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var PhoneList = new List<Phone>
            {
                new Phone { PhoneName = "Samsung note 10+" , PhoneId = 0, Manufacturer ="US", MSRP=0, ScreenSize= 6, DateRelease = new DateTime(2000,09,06)},
                new Phone {PhoneName = "Iphone 11 pro", , PhoneId = 0, Manufacturer ="US", MSRP=0, ScreenSize= 6, DateRelease = new DateTime(2019,10,06)},
                new Phone {PhoneName = "OnePlus 7", , PhoneId = 0, Manufacturer ="US", MSRP=0, ScreenSize= 6, DateRelease = new DateTime(2019,04,06)},
                new Phone {PhoneName = "Gionee", , PhoneId = 0, Manufacturer ="US", MSRP=0, ScreenSize= 6, DateRelease = new DateTime(2000,09,06)},
                new Phone {PhoneName = "Samsung galaxy 8", , PhoneId = 0, Manufacturer ="US", MSRP=0, ScreenSize= 6, DateRelease = new DateTime(2000,09,06)}
            };

            return View(PhoneList);
        }
    }
}