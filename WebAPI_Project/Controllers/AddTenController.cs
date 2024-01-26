using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class AddTenController : ApiController
    {
        // <summary>
        // This Method adds ten to each number that is assign to the id parameter.
        //Usage:
        // localhost:xx/api/AddTen/10 => 20
        // </summary>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}