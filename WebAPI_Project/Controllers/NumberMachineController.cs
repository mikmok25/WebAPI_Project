using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id) 
        {
            if (id < 0)
            {
                return id + 10;
            }
            else if (id >= 1 && id <= 10)
            {
                return id - 1;
            }
            else if (id > 10 && id <= 20) {
                return id * id;
            }
            else
            {
                return id / 2;
            }
        }
    }
}