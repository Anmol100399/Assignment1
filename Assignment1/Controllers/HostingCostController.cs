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
            public double Get(int id)
            { 
            double fortNightCost = 5.50;// cost of fortNight
            double fortNight = (id + 1) / 14;
            double subtotal = fortNight * fortNightCost;
            double hst = subtotal * 0.13;// Calculate HST
            double totalCost = subtotal + hst;// Calculate total
            return subtotal;
            return hst;
            return totalCost;
            }
    }
}
//Facing Problem in "RETURN HST"
//"Not getting expected Output"
//Not sure if we can use public double Get(int id)
//Not sure if we can use Return Return Return three times for getting the output
//Tried my best :')