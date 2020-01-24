using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneId = 0;
            PhoneName = "";
            Manufacturer = "";
            MSRP = 0;
            ScreenSize = 0;
            DateRelease = new DateTime();
           
      
        }
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public Double MSRP { get; set; }
        public Double ScreenSize { get; set; }
        public DateTime DateRelease { get; set; }

    }
}