using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingPeopleController : ApiController
    {

        public string Get (int id)
        {
            string greeting = "Greeting to " + id + " people!";
            return greeting;
            //Get localhost:xx/api/GreetingPeople/{id}
            /// <summary>
            /// returns a message of greeting and an integer(no. of people)
            /// </summary>
            /// <returns>
            /// returns a message and an integer(no. of people)
            /// </returns>
            /// <example>
            ///GET localhost:xx/api/GreetingPeople/3 ->Greetings to 3 people!
            ///GET localhost:xx/api/GreetingPeople/6 ->Greetings to 6 people!
            ///GET localhost:xx/api/GreetingPeople/0 ->Greetings to 0 people!
            /// </example>
            /// curl -d "" http://localhost:60606/api/GreetingPeople/{id}
        }
    }
}
