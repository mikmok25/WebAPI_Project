using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class IntegerController : ApiController
    {
        public int Get()
        {
            return 5 + 5;
        }

        public int Get(int id)
        {
            return id;
        }
    }
}
