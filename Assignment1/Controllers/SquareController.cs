using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //GET localhost:xx/api/Square/2 4
        //GET localhost:xx/api/Square/-2 4
        //GET localhost:xx/api/Square/10 100
        public int Get(int id)
        {
            int multiply = id * id;
            return multiply;
            //Get localhost:xx/api/Square/{id}
            /// <summary>
            /// returns an integer by squaring or multiple the input value by itself
            /// </summary>
            /// <returns>
            /// returns an integer by making it square of the input value
            /// </returns>
            /// curl -d "" http://localhost:60606/api/Square/{id}
        }
    }
}
