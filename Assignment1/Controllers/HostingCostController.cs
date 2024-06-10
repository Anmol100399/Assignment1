using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
            public string Get(int id)
            { 
            int fortNight = (id + 1) / 14;
            double subtotal = fortNight * 5.50;
            double hst = subtotal * 0.13;// Calculate HST
            double totalCost = subtotal + hst;// Calculate total

            // Construct the response strings
            string print1 = $"{fortNight} fortnights at $5.50/FN = ${subtotal:F2} CAD";
            //  :f2 means 2 digits after the decimal point.
            string print2 = $"HST 13% = ${hst:F2} CAD";
            // $ identifies a string literal as an interpolated string.
            string print3 = $"Total = ${totalCost:F2} CAD";

            // Returning the all three string
            return $"{print1}\n{print2}\n{print3}";
            }
    }
}
//Facing Problem in "RETURN HST"
//"Not getting expected Output"
//Not sure if we can use public double Get(int id)
//Not sure if we can use Return Return Return three times for getting the output
//Tried my best :')
