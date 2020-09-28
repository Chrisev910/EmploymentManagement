using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentManagement.Controllers
{
    public class HomeController : Controller
    {

        public JsonResult Index()
        {
            JsonResult result;

                result = Json(new { id = 1, name = "Chris" });

            return result;
                
                
        }
    }
}
