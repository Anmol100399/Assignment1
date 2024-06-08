using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //POST localhost:xx/api/Greeting  -> Hello World!
        /// <summary>
        /// returns a message
        /// </summary>
        /// <returns>
        /// Hello World!
        /// </returns>
        /// curl -d "" http://localhost:60606/api/Greeting
        public string Post()
        {
            string response = "Hello World!";
            return response;
        }

        /// <summary>
        /// receives an integer and returns a message "greeting to 'X' people!" where X is the no. of people in the input value
        /// </summary>
        /// <param name="id">number of people</param>
        /// <returns>
        /// Greeting to {id} people!
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/Greeting/3 ->Greetings to 3 people!
        /// GET localhost:xx/api/Greeting/6 ->Greetings to 6 people!
        /// GET localhost:xx/api/Greeting/0 ->Greetings to 0 people!
        /// </example>
        public string Get(int id)
        {
            string greeting = "Greeting to " + id + " people!";
            return greeting;
        }
    }
}
