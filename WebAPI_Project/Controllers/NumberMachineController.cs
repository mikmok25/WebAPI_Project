using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    //<summary>
    // This method demonstrate different mathematical operations based on the number of id provided.
    // usage:
    // id <= -1 + 10 => 9
    // id = 9 - 1 => 8
    // id = 11 * 11 => 121
    // id = 30 / 2 => 15
    //</summary>
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
