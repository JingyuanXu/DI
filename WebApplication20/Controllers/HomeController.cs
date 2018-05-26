using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication18;

namespace WebApplication20.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBook _ibook;

        public HomeController(IBook ibook)
        {
            _ibook = ibook;
        }
        public ActionResult Index()
        {
            string bookInfo = this._ibook.GetBookInformation();
            return View(bookInfo as object);
        }
    }
}
