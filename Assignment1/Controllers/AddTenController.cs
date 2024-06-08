using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET localhost:xx/api/AddTen/21 ->31
        //GET localhost:xx/api//AddTen/0 ->10
        //GET localhost:xx/api/AddTen/-9 ->1
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
            //Get localhost:xx/api/AddTen/{id}
            /// <summary>
            /// returns an integer by adding 10 to the input value
            /// </summary>
            /// <returns>
            /// returns an integer by adding 10 to the input value
            /// </returns>
            /// curl -d "" http://localhost:60606/api/AddTen/{id}
        }
    }
}