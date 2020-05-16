using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SSuwalaBonjourLeMonde.Controllers
{
    public class GetController : Controller
    {
        public String Index()
        {
            return "Hello, it's me, GetController!";
        }
    }
}