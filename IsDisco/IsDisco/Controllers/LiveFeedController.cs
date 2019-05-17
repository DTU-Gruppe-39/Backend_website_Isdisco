using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IsDisco.Controllers
{
    public class LiveFeedController : Controller
    {

        // 
        // GET: //

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Home/Livefeed/ 
        public string Livefeed()
        {
            return "This is the Welcome action method...";
        }
    }
}
