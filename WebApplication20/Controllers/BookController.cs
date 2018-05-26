using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication18;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication20.Controllers
{
    public class BookController : ApiController
    {
        private readonly IBook _ibook;

        public BookController(IBook ibook)
        {
            _ibook = ibook;
        }
      
        // GET api/book
        [System.Web.Http.HttpGet]
        public string Get()
        {
            string bookInfo = this._ibook.GetBookInformation();
            return bookInfo;
        }

    }
}
