// Andrew Nilsson
// 10/26/22
// Odd or Even - Endpoints
// This is a webapi that inputs a number and outputs a string telling if the number is odd or even
// Reviewed by Dan Decoito: The Code and the api integration both work well.  


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_OddOrEvenEndpoints.Controllers
{
    [Route("[controller]")]
    public class OddOrEvenController : Controller
    {
        [HttpGet]
        [Route("Number/{num}")]

        public string Number(int num)
        {
            int r = num % 2;

            if (r == 0) return $"{num} is even";
            return $"{num} is odd";
        }
    }
}