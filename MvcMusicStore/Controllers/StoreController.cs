using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from Store.Index()";
        }

        public string Browse(string genre)
        {
            return HttpUtility.HtmlEncode("Store.Brose, Genre = " + genre);
        }

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}
