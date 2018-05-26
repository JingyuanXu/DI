using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication18
{
    public class Book:IBook
    {
        public string GetBookInformation()
        {
            return"Book";
        }
    }
}