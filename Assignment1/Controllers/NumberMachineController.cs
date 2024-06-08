using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
   /*   GET localhost/NumberMachine/10 -> 
        GET localhost/NumberMachine/-5 ->
        GET localhost/NumberMachine/30 -> */
    public class NumberMachineController : ApiController
    {
//GET : api/NumberMachine/Addition/{id} 
        [HttpGet]
        //[Route("api/NumberMachine/Addition/{id}")] 
        //Instead of removing above line, I am putting it in comments for my reference.
            public int Addition(int id)
            {
                int sum = id + id;
                return sum;
            }
        /// <summary>
        /// returns an integer value by the addition of a same input number
        /// </summary>
        /// <param name="id">input the value</param>
        /// <returns>an integer by adding the input number twice</returns>
        /// <example>
        /// GET localhost/NumberMachine/10 ->20
        ///GET localhost/NumberMachine/-5 ->-10
        ///GET localhost/NumberMachine/30 ->60
        /// </example>
        /// curl http://localhost:60606/api/NumberMachine/Addition/{id}
//GET : api/NumberMachine/Subtract/{id}
        [HttpGet]
        public int Subtract(int id)
        {
            int sub = id - id;
            return sub;
        }
        /// <summary>
        /// returns an integer value by the subtracting of a same input number
        /// </summary>
        /// <param name="id">input the value</param>
        /// <returns>an integer by subtracting the input number twice</returns>
        /// <example>
        /// GET localhost/NumberMachine/10 ->0
        ///GET localhost/NumberMachine/-5 ->0
        ///GET localhost/NumberMachine/30 ->0
        ///Subtracting number by itself gives you 0 (zero)
        ///</example>
        ///curl http://localhost:60606/api/NumberMachine/Subtract/{id}
//GET : api/NumberMachine/Multiply/{id}        
        [HttpGet]
        public int Multiply(int id)
        {
            int multi = id * id;
            return multi;
        }
        /// <summary>
        /// returns an integer value by the multiplication of a same input number
        /// </summary>
        /// <param name="id">input the value</param>
        /// <returns>an integer by multiplying the input number twice</returns>
        /// <example>
        /// GET localhost/NumberMachine/10 ->100
        ///GET localhost/NumberMachine/-5 ->25
        ///GET localhost/NumberMachine/30 ->900
        /// </example>
        /// curl http://localhost:60606/api/NumberMachine/Multiply/{id}
// GET : api/NumberMachine/Divide/{id}
        [HttpGet]
        public int Divide(int id)
        {
            int div = id / id;
            return div;
        }
        /// <summary>
        /// returns an integer value by the division of a same input number
        /// </summary>
        /// <param name="id">input the value</param>
        /// <returns>an integer by dividing the input number twice</returns>
        /// <example>
        /// GET localhost/NumberMachine/10 ->1
        ///GET localhost/NumberMachine/-5 ->1
        ///GET localhost/NumberMachine/30 ->1
        ///Divide any number by itself gives you 1
        /// </example>
        /// curl http://localhost:60606/api/NumberMachine/Divide/{id}
    }
}

